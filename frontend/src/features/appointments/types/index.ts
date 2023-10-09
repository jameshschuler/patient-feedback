export interface StepData {
  text: string;
  order: number;
  questionType: QuestionType;
  questionId: string;
  questionName: string;
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
  questionId: string;
  questionType: QuestionType;
  questionName: string;
  value?: string;
}

export interface SaveFeedbackRequest {
  appointmentId: string;
  questionAnswers: Array<FeedbackQuestionAnswer>;
}

export interface FeedbackQuestionAnswer {
  appointmentFeedbackQuestionId: string;
  value: string;
}

export interface SaveFeedbackResponse {
  questionAnswers: Array<QuestionAnswer>;
}

export interface QuestionAnswer {
  question: string;
  answer: string;
}
