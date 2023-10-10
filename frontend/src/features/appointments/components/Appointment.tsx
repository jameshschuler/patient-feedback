import { Link } from "react-router-dom";

interface AppointmentProps {
  appointmentId: string;
  status: string;
  submittedDate?: string;
}

export function Appointment({
  appointmentId,
  status,
  submittedDate,
}: AppointmentProps) {
  return (
    <div className="flex gap-8">
      <p>
        <Link to={`/appointments/${appointmentId}/feedback`}>
          {appointmentId}
        </Link>
      </p>
      <p>{status}</p>
      <p>{submittedDate && new Date(submittedDate).toLocaleDateString()}</p>
    </div>
  );
}
