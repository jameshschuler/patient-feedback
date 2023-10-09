export interface ApiResponse<T> {
  data: T;
  errorMessage?: string;
}

export enum MessageType {
  Error,
  Success,
}
