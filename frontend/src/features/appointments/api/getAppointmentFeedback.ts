import { axios } from "@/lib/axios";
import { ApiResponse } from "@/shared/types";
import { useQuery } from "@tanstack/react-query";
import { AppointmentFeedbackResponse } from "../types";

function getAppointmentFeedback(
  appointmentId?: string
): Promise<ApiResponse<AppointmentFeedbackResponse>> {
  return axios
    .get(`/appointment/${appointmentId}/feedback`)
    .then((res) => res.data);
}

interface UseAppointmentFeedbackOptions {
  appointmentId?: string;
}

export const useAppointmentFeedback = ({
  appointmentId,
}: UseAppointmentFeedbackOptions) => {
  return useQuery({
    queryKey: [`appointment_feedback_${appointmentId}`],
    queryFn: () => getAppointmentFeedback(appointmentId),
  });
};
