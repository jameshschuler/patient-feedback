import { Skeleton } from "@/shared";
import { useState } from "react";
import { useForm } from "react-hook-form";
import { useCreateAppointmentFeedback } from "../api/createAppointmentFeedback";
import { SaveFeedbackRequest, StepData } from "../types";
import { Step } from "./Step";

interface FeedbackFormProps {
  appointmentId: string;
  loading: boolean;
  steps: StepData[];
}

export function FeedbackForm({
  appointmentId,
  loading,
  steps,
}: FeedbackFormProps) {
  const [currentStep, setCurrentStep] = useState(1);
  const [hasNextStep, setHasNextStep] = useState(true);
  const [hasPrevStep, setHasPrevStep] = useState(false);

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

  // TODO: need to show overview component / step at end

  const {
    register,
    handleSubmit,
    formState: { errors, isValid },
  } = useForm();

  const createMutation = useCreateAppointmentFeedback();

  const handleSaveFeedback = async (fieldData: any) => {
    if (isValid && fieldData) {
      const request: SaveFeedbackRequest = {
        appointmentId: appointmentId!,
        questionAnswers: Object.keys(fieldData).map((key: string) => {
          return {
            appointmentFeedbackQuestionId: key,
            value: fieldData[key] ? fieldData[key] : null,
          };
        }),
      };
      const r = await createMutation.mutateAsync(request);
      console.log(r);
    }
  };

  return (
    <>
      <Skeleton loading={loading}>
        <h3 className="text-lg my-6">
          Question {currentStep} of {steps.length}
        </h3>
      </Skeleton>
      <form
        className="min-h-[300px]"
        onSubmit={handleSubmit(handleSaveFeedback)}
      >
        <div className="min-h-[300px]">
          {steps.length !== 0 &&
            steps.map(({ order, questionId, questionType, text }: StepData) => {
              return (
                <Step
                  key={questionId}
                  visible={currentStep === order}
                  questionType={questionType}
                  register={register}
                  name={questionId}
                  text={text}
                />
              );
            })}
        </div>
        <Skeleton loading={loading} height="h-12">
          <div className="flex justify-between items-center">
            <button className="btn bg-slate-100 hover:bg-slate-300">
              Cancel
            </button>
            <div>
              <button
                type="button"
                className="btn bg-blue-100 hover:bg-blue-300 mr-4 disabled:bg-gray-100"
                disabled={!hasPrevStep}
                onClick={handlePrevStep}
              >
                Previous
              </button>
              {hasNextStep && (
                <button
                  type="button"
                  className="btn bg-green-200 hover:bg-green-400 disabled:bg-gray-100"
                  disabled={!hasNextStep}
                  onClick={handleNextStep}
                >
                  Next
                </button>
              )}
              {!hasNextStep && (
                <button
                  type="submit"
                  className="btn bg-green-200 hover:bg-green-400 disabled:bg-gray-100"
                  onClick={handleSaveFeedback}
                >
                  Finish
                </button>
              )}
            </div>
          </div>
        </Skeleton>
      </form>
    </>
  );
}
