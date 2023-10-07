import { StepData } from "../types";
import { Step } from "./Step";

interface StepsProps {
  currentStep: number;
  steps: Array<StepData>;
}

export function Steps({ currentStep, steps }: StepsProps) {
  console.log(currentStep);

  return (
    <div className="min-h-[300px]">
      <Step text={steps[currentStep - 1].text} />
    </div>
  );
}
