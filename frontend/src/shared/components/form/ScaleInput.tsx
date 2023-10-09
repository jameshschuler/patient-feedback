import { ReactNode, useEffect, useState } from "react";
import { FieldValues, UseFormRegister } from "react-hook-form";

interface ScaleInputProps {
  name: string;
  register: UseFormRegister<FieldValues>;
  min: number;
  max: number;
}

export function ScaleInput({ name, register, min, max }: ScaleInputProps) {
  const [radioInputs, setRadioInputs] = useState<ReactNode[]>([]);

  useEffect(() => {
    const inputs = [];
    for (let index = min; index <= max; index++) {
      inputs.push(
        <div
          className="flex flex-col items-center mr-10 form-field"
          key={index}
        >
          <input
            type="radio"
            {...register(name)}
            min={min}
            max={max}
            step={1}
            value={index}
            id={`radio_${index}`}
          ></input>
          <label className="mt-2" htmlFor={`radio_${index}`}>
            {index}
          </label>
        </div>
      );
    }
    setRadioInputs(inputs);
  }, [min, max]);

  return <fieldset className="flex">{radioInputs}</fieldset>;
}
