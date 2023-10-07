import { API_URL } from "@/config";
import Axios from "axios";

export const axios = Axios.create({
  baseURL: API_URL,
});

axios.interceptors.response.use(
  (response) => response,
  (error) => {
    if (error.response.status === 404) {
      const errorMessage =
        error.response.data.errorMessage ??
        "We can't seem to find what you're looking for!";
      return Promise.reject(errorMessage);
    }
    return Promise.reject(error);
  }
);
