import { Question, QuestionType } from "@/features/appointments/types";
import { rest } from "msw";

export const handlers = [
  // Handles a GET /user request
  rest.get(
    "https://localhost:7115/api/appointment/:appointmentId/feedback",
    (req, res, ctx) => {
      return res(
        ctx.status(200),

        ctx.json({
          data: {
            appointmentId: "hello",
            questions: [
              {
                text: "How are you?",
                questionId: "57154456-a8e6-48fc-8cec-c2b683e8996b",
                questionType: QuestionType.Scale,
                questionName: "HowAreYou",
              },
            ] as Question[],
          },
        })
      );
    }
  ),
];
