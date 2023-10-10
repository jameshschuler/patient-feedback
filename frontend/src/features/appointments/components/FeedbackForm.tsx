import { Skeleton } from "@/shared";
import { useEffect, useState } from "react";
import { useForm } from "react-hook-form";
import { useCreateAppointmentFeedback } from "../api/createAppointmentFeedback";
import { QuestionAnswer, SaveFeedbackRequest, StepData } from "../types";
import { Step } from "./Step";

interface FeedbackFormProps {
  appointmentId: string;
  loading: boolean;
  steps: StepData[];
  onSuccess: (questionAnswers: QuestionAnswer[]) => void;
}

export function FeedbackForm({
  appointmentId,
  loading,
  onSuccess,
  steps,
}: FeedbackFormProps) {
  const [currentStep, setCurrentStep] = useState(1);
  const [hasNextStep, setHasNextStep] = useState(false);
  const [hasPrevStep, setHasPrevStep] = useState(false);

  useEffect(() => {
    if (steps.length > 1) {
      setHasNextStep(true);
    }
  }, [steps.length]);

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

  const { register, handleSubmit, formState } = useForm({ mode: "onChange" });

  const createMutation = useCreateAppointmentFeedback();

  const handleSaveFeedback = async (fieldData: any) => {
    if (Object.keys(formState.errors).length !== 0) {
      // TODO: show error
      return;
    }

    const request: SaveFeedbackRequest = {
      appointmentId: appointmentId!,
      questionAnswers: Object.keys(fieldData).map((key: string) => {
        return {
          appointmentFeedbackQuestionId: key,
          value: fieldData[key] ?? null,
        };
      }),
    };
    const response = await createMutation.mutateAsync(request);
    if (response.status === 201) {
      onSuccess(response.data.data.questionAnswers);
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
        <Skeleton loading={loading} height="min-h-[200px]">
          <div className="min-h-[300px]">
            {steps.length !== 0 &&
              steps.map(
                ({ order, questionId, questionType, text }: StepData) => {
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
                }
              )}
          </div>
        </Skeleton>
        <Skeleton loading={loading} height="h-12">
          <div className="flex justify-between items-center">
            <button className="btn bg-slate-100 hover:bg-slate-300">
              Cancel
            </button>
            <div>
              {hasPrevStep && (
                <button
                  type="button"
                  className="btn bg-blue-100 hover:bg-blue-300 mr-4 disabled:bg-gray-100"
                  onClick={handlePrevStep}
                >
                  Previous
                </button>
              )}

              {hasNextStep && (
                <button
                  type="button"
                  className="btn bg-green-200 hover:bg-green-400 disabled:bg-gray-100"
                  disabled={!hasNextStep}
                  onClick={handleNextStep}
                  data-testid="next-btn"
                >
                  Next
                </button>
              )}
              {!hasNextStep && (
                <button
                  type="submit"
                  className="btn bg-green-200 hover:bg-green-400 disabled:bg-gray-100"
                  onClick={handleSaveFeedback}
                  disabled={
                    createMutation.isLoading ||
                    Object.keys(formState.errors).length !== 0
                  }
                  data-testid="submit-btn"
                >
                  Submit
                </button>
              )}
            </div>
          </div>
        </Skeleton>
      </form>
    </>
  );
}
