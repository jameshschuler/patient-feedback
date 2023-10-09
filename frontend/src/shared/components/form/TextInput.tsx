import { FieldValues, UseFormRegister } from "react-hook-form";

interface TextInputProps {
  name: string;
  register: UseFormRegister<FieldValues>;
}

export function TextInput({ name, register }: TextInputProps) {
  return (
    <fieldset>
      <textarea
        rows={6}
        className="w-full border border-black rounded-lg p-4"
        {...register(name)}
      ></textarea>
    </fieldset>
  );
}
