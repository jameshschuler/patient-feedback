import { useState } from "react";
import { FieldValues, UseFormRegister } from "react-hook-form";

interface TextInputProps {
  name: string;
  register: UseFormRegister<FieldValues>;
  maxLength: number;
}

export function TextInput({ maxLength, name, register }: TextInputProps) {
  const [value, setValue] = useState<string | null>(null);

  function handleOnChange(event: React.ChangeEvent<HTMLInputElement>) {
    setValue(event.target.value);
  }

  return (
    <fieldset>
      <textarea
        rows={6}
        className="w-full border border-black rounded-lg p-4"
        {...register(name, {
          maxLength,
          onChange: handleOnChange,
          required: false,
        })}
      ></textarea>
      <p
        className={`mr-2 text-gray-600 text-sm text-right ${
          value && value.length > maxLength ? "text-red-400" : ""
        }`}
      >
        {value?.length ?? 0} / {maxLength}
      </p>
    </fieldset>
  );
}

TextInput.defaultProps = {
  maxLength: 250,
};
