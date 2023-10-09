import { Link } from "react-router-dom";
import { QuestionAnswer } from "../types";

interface FeedbackOverviewProps {
  questionAnswers: QuestionAnswer[];
  title: string;
}

export function FeedbackOverview({
  questionAnswers,
  title,
}: FeedbackOverviewProps) {
  return (
    <div>
      <h1 className="text-2xl my-4 font-semibold">{title}</h1>
      {questionAnswers.length !== 0 &&
        questionAnswers.map(
          ({ question, answer }: QuestionAnswer, index: number) => {
            return (
              <div key={index} className="my-6 ml-4">
                <p>{question}</p>
                <p className="font-bold">{answer}</p>
              </div>
            );
          }
        )}
      <div className="mt-12 flex justify-center">
        <Link to="/appointments" className="btn bg-blue-100 mt-12">
          Back to Appointments
        </Link>
      </div>
    </div>
  );
}
