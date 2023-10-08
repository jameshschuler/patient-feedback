import { FieldValues, UseFormRegister } from "react-hook-form";

interface ScaleInputProps {
  name: string;
  register: UseFormRegister<FieldValues>;
}

export function ScaleInput({ name, register }: ScaleInputProps) {
  return (
    <fieldset>
      <input
        type="range"
        defaultValue={1}
        min={1}
        max={10}
        step={1}
        {...register(name)}
      ></input>
    </fieldset>
  );
}
