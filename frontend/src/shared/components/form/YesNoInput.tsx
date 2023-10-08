import { FieldValues, UseFormRegister } from "react-hook-form";

interface YesNoInputProps {
  name: string;
  register: UseFormRegister<FieldValues>;
}

export function YesNoInput({ name, register }: YesNoInputProps) {
  return (
    <fieldset>
      <div>
        <input
          id="yes"
          type="radio"
          className="mr-2"
          value={"yes"}
          {...register(name)}
        />
        <label htmlFor="yes">Yes</label>
      </div>
      <div className="mt-4">
        <input
          id="no"
          type="radio"
          className="mr-2"
          value={"no"}
          {...register(name)}
        />
        <label htmlFor="no">No</label>
      </div>
    </fieldset>
  );
}
