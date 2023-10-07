interface StepProps {
  text: string;
}

export function Step({ text }: StepProps) {
  return (
    <div>
      <p>{text}</p>
    </div>
  );
}
