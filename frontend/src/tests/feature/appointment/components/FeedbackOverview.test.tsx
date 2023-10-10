import { FeedbackOverview } from "@/features/appointments/components/FeedbackOverview";
import { render, screen } from "@testing-library/react";
import { MemoryRouter } from "react-router-dom";
import { describe, expect, it } from "vitest";

describe("AppointmentFeedbackWizard", () => {
  it("renders title and question/answer", () => {
    const title = "Thanks again! Here's what we heard:";
    const questionsAnswers = [
      {
        question: "Hey hey how are you?",
        answer: "I'm great thanks for asking",
      },
    ];
    render(
      <MemoryRouter>
        <FeedbackOverview title={title} questionAnswers={questionsAnswers} />
      </MemoryRouter>
    );
    expect(screen.getByText(title)).toBeInTheDocument();
    expect(
      screen.getByText(questionsAnswers.at(0)!.question)
    ).toBeInTheDocument();
    expect(
      screen.getByText(questionsAnswers.at(0)!.answer)
    ).toBeInTheDocument();
  });
});
