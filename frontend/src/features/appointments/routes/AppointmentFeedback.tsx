import { AppointmentFeedbackWizard } from "../components/AppointmentFeedbackWizard";

export function AppointmentFeedback() {
  return (
    <div className="m-20">
      <h1 className="text-3xl">Patient Appointment Feedback</h1>
      <AppointmentFeedbackWizard />
    </div>
  );
}
