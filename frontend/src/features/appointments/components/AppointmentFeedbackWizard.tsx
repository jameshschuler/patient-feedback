import { Message } from "@/shared";
import { MessageType } from "@/shared/types";
import { useEffect, useState } from "react";
import { useParams } from "react-router-dom";
import { useAppointmentFeedback } from "../api/getAppointmentFeedback";
import { Question, QuestionAnswer } from "../types";
import { FeedbackForm } from "./FeedbackForm";
import { FeedbackOverview } from "./FeedbackOverview";

export function AppointmentFeedbackWizard() {
  const { appointmentId } = useParams();
  const { data, isLoading, isError, error } = useAppointmentFeedback({
    appointmentId,
  });

  const [steps, setSteps] = useState<Question[]>([]);

  const [overviewTitle, setOverviewTitle] = useState<string>("");
  const [questionAnswers, setQuestionAnswers] = useState<QuestionAnswer[]>([]);
  function onSuccess(questionAnswers: QuestionAnswer[]) {
    setQuestionAnswers(questionAnswers);
  }

  useEffect(() => {
    if (data?.data.submittedDate) {
      const questionAnswers = data.data.questions.map(
        ({ text, value }: Question) => {
          return {
            question: text,
            answer: value,
          } as QuestionAnswer;
        }
      );
      setQuestionAnswers(questionAnswers);
      setOverviewTitle(
        `We received your feedback on ${new Date(
          data.data.submittedDate
        ).toLocaleDateString()}`
      );
    } else {
      setSteps(data?.data.questions ?? []);
      setOverviewTitle("Thanks again! Here's what we heard:");
    }
  }, [data?.data.questions, data?.data.submittedDate, isLoading]);

  return (
    <div className="md:p-24 p-6 bg-white rounded-2xl mt-12 shadow-lg">
      <h1 className="text-3xl mb-8">Patient Appointment Feedback</h1>
      {isError && (
        <Message messageType={MessageType.Error} text={error as string} />
      )}
      {!isError && questionAnswers.length === 0 && (
        <FeedbackForm
          appointmentId={appointmentId!}
          loading={isLoading}
          steps={steps}
          onSuccess={onSuccess}
        ></FeedbackForm>
      )}
      {questionAnswers.length !== 0 && (
        <FeedbackOverview
          questionAnswers={questionAnswers}
          title={overviewTitle}
        ></FeedbackOverview>
      )}
    </div>
  );
}
