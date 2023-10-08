import { StepData } from "../types";
import { Step } from "./Step";

interface StepsProps {
  currentStep: number;
  steps: Array<StepData>;
}

export function Steps({ currentStep, steps }: StepsProps) {
  return (
    <form className="min-h-[300px]">
      {steps &&
        steps.map(({ order, questionType, text }: StepData) => {
          return (
            <Step
              questionType={questionType}
              text={text}
              visible={currentStep === order}
              key={order}
            />
          );
        })}
    </form>
  );
}
