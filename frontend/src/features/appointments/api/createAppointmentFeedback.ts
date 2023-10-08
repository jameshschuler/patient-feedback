import { axios } from "@/lib/axios";
import { useMutation } from "@tanstack/react-query";
import { AxiosResponse } from "axios";
import { SaveFeedbackRequest } from "../types";

export const createAppointmentFeedback = (
  request: SaveFeedbackRequest
): Promise<AxiosResponse> => {
  return axios.post("/appointment/feedback", request);
};

export const useCreateAppointmentFeedback = () => {
  return useMutation({
    onError: (error, __, context: any) => {
      console.error(error);
    },
    onSuccess: () => {},
    mutationFn: createAppointmentFeedback,
  });
};
