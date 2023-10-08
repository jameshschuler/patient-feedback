import { ScaleInput, TextInput, YesNoInput } from "@/shared";
import { FieldValues, UseFormRegister } from "react-hook-form";
import { QuestionType } from "../types";

interface StepProps {
  name: string;
  questionType: QuestionType;
  register: UseFormRegister<FieldValues>;
  text: string;
  visible: boolean;
}

export function Step({
  name,
  register,
  questionType,
  text,
  visible,
}: StepProps) {
  return (
    <div className={`${visible ? "" : "hidden"}`}>
      <p>{text}</p>
      <div className="py-6 ml-4">
        {questionType === QuestionType.Scale && (
          <ScaleInput name={name} register={register} />
        )}
        {questionType === QuestionType.Text && (
          <TextInput name={name} register={register} />
        )}
        {questionType === QuestionType.YesNo && (
          <YesNoInput name={name} register={register} />
        )}
      </div>
    </div>
  );
}
