import { DataTable } from "@/shared";
import { useAllAppointments } from "../api/getAllAppointments";
import { Appointment } from "../components/Appointment";

export function Appointments() {
  const patientId = "98ca4b72-dd7b-4bb1-9e25-4d13805dcd30";

  const { data } = useAllAppointments({
    patientId,
  });

  return (
    <div>
      {data?.data && (
        <DataTable
          title="Recent Appointments"
          data={data.data.appointments}
          render={({ appointmentId, status, submittedDate }) => (
            <Appointment
              key={appointmentId}
              appointmentId={appointmentId}
              status={status}
              submittedDate={submittedDate}
            ></Appointment>
          )}
        ></DataTable>
      )}
    </div>
  );
}
