export interface StepData {
  text: string;
  order: number;
  questionType: QuestionType;
}

export enum QuestionType {
  YesNo = 0,
  Scale = 1,
  Text = 2,
}

export interface AppointmentFeedbackResponse {
  appointmentId: string;
  appointmentType: string;
  appointmentFeedbackId: string;
  status: string;
  submittedDate?: string;
  questions: Array<Question>;
}

export interface Question {
  text: string;
  order: number;
  questionType: QuestionType;
}
