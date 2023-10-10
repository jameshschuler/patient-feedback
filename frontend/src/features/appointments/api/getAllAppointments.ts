import { axios } from "@/lib/axios";
import { ApiResponse } from "@/shared/types";
import { useQuery } from "@tanstack/react-query";
import { GetAllAppointmentsResponse } from "../types";

function getAllAppointments(
  patientId?: string
): Promise<ApiResponse<GetAllAppointmentsResponse>> {
  return axios.get(`/appointment/patient/${patientId}`).then((res) => res.data);
}

interface UseAllAppointmentOptions {
  patientId?: string;
}

export const useAllAppointments = ({ patientId }: UseAllAppointmentOptions) => {
  return useQuery({
    queryKey: [`all_appointments_${patientId}`],
    queryFn: () => getAllAppointments(patientId),
  });
};
