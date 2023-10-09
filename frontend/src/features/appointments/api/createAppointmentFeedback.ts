import { axios } from "@/lib/axios";
import { ApiResponse } from "@/shared/types";
import { useMutation } from "@tanstack/react-query";
import { AxiosResponse } from "axios";
import { SaveFeedbackRequest, SaveFeedbackResponse } from "../types";

export const createAppointmentFeedback = (
  request: SaveFeedbackRequest
): Promise<AxiosResponse<ApiResponse<SaveFeedbackResponse>>> => {
  return axios.post("/appointment/feedback", request);
};

export const useCreateAppointmentFeedback = () => {
  return useMutation({
    onError: (error, _, context: any) => {
      console.error(error);
    },
    onSuccess: () => {},
    mutationFn: createAppointmentFeedback,
  });
};
