import { DataTable } from "@/shared";
import { useAllAppointments } from "../api/getAllAppointments";

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
          render={(a) => (
            <div key={a.appointmentId}>
              <p>{a.appointmentId}</p>
            </div>
          )}
        ></DataTable>
      )}
    </div>
  );
}
