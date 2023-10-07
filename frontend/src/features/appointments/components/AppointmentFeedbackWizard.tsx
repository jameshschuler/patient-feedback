import { Message } from "@/shared";
import { MessageType } from "@/shared/types";
import { useEffect, useState } from "react";
import { useParams } from "react-router-dom";
import { useAppointmentFeedback } from "../api/getAppointmentFeedback";
import { Question } from "../types";
import { Steps } from "./Steps";

export function AppointmentFeedbackWizard() {
  const { appointmentId } = useParams();
  const { data, isLoading, isError, error } = useAppointmentFeedback({
    appointmentId,
  });

  const [currentStep, setCurrentStep] = useState(1);
  const [hasNextStep, setHasNextStep] = useState(true);
  const [hasPrevStep, setHasPrevStep] = useState(false);
  const [steps, setSteps] = useState<Question[]>([]);

  useEffect(() => {
    setSteps(data?.data?.questions ?? []);
  }, [data?.data?.questions, isLoading]);

  function handleNextStep() {
    const nextStep = currentStep + 1;
    setCurrentStep(nextStep);
    setHasPrevStep(true);

    if (nextStep + 1 > steps.length) {
      setHasNextStep(false);
    }
  }

  function handlePrevStep() {
    const prevStep = currentStep - 1;
    setCurrentStep(prevStep);
    setHasNextStep(true);

    if (prevStep - 1 <= 0) {
      setHasPrevStep(false);
    }
  }

  // TODO: handle loading state
  // TODO: handle form state and validation
  // TODO: need to make sure each step is valid before allowing next step
  return (
    <div className="p-24 bg-white rounded-2xl mt-12 shadow-lg">
      {isError && (
        <Message messageType={MessageType.Error} text={error as string} />
      )}
      {!isError && (
        <div>
          <h3 className="text-lg my-6">
            Question {currentStep} of {steps.length}
          </h3>
          {steps.length && <Steps currentStep={currentStep} steps={steps} />}
          <div className="flex justify-between items-center">
            <button className="btn bg-slate-100 hover:bg-slate-300">
              Cancel
            </button>
            <div>
              <button
                className="btn bg-blue-100 hover:bg-blue-300 mr-4 disabled:bg-gray-100"
                disabled={!hasPrevStep}
                onClick={handlePrevStep}
              >
                Previous
              </button>
              {hasNextStep && (
                <button
                  className="btn bg-green-200 hover:bg-green-400 disabled:bg-gray-100"
                  disabled={!hasNextStep}
                  onClick={handleNextStep}
                >
                  Next
                </button>
              )}
              {!hasNextStep && (
                <button className="btn bg-green-200 hover:bg-green-400 disabled:bg-gray-100">
                  Finish
                </button>
              )}
            </div>
          </div>
        </div>
      )}
    </div>
  );
}
