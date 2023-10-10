import { FeedbackForm } from "@/features/appointments/components/FeedbackForm";
import {
  QuestionAnswer,
  QuestionType,
  StepData,
} from "@/features/appointments/types";
import { queryClient } from "@/lib/react-query";
import { renderWithClient } from "@/tests/utils";
import { fireEvent } from "@testing-library/react";
import { MemoryRouter } from "react-router-dom";
import { describe, expect, it } from "vitest";

describe("FeedbackForm", () => {
  it("renders initial feedback form for multiple questions", () => {
    const appointmentId = "";
    const steps = [
      {
        text: "Example",
        order: 1,
        questionType: QuestionType.Scale,
        questionId: "b5a8dbbe-9ef4-4df4-97bd-ff3ee78c874e",
        questionName: "Example",
      },
      {
        text: "Example 2",
        order: 2,
        questionType: QuestionType.Scale,
        questionId: "b5a8dbbe-9ef4-4df4-97bd-ee3ee78c874e",
        questionName: "Example 2",
      },
    ] as Array<StepData>;
    const onSuccess = (questionAnswers: QuestionAnswer[]) => {};
    const screen = renderWithClient(
      queryClient,
      <MemoryRouter>
        <FeedbackForm
          appointmentId={appointmentId}
          loading={false}
          steps={steps}
          onSuccess={onSuccess}
        />
      </MemoryRouter>
    );

    expect(
      screen.getByText(`Question 1 of ${steps.length}`)
    ).toBeInTheDocument();
    expect(screen.getByTestId("next-btn")).toBeInTheDocument();
    expect(screen.queryByTestId("submit-btn")).not.toBeInTheDocument();
  });

  it("renders initial feedback form with a single question", () => {
    const appointmentId = "";
    const steps = [
      {
        text: "Example",
        order: 1,
        questionType: QuestionType.Scale,
        questionId: "b5a8dbbe-9ef4-4df4-97bd-ff3ee78c874e",
        questionName: "Example",
      },
    ] as Array<StepData>;
    const onSuccess = (questionAnswers: QuestionAnswer[]) => {};
    const screen = renderWithClient(
      queryClient,
      <MemoryRouter>
        <FeedbackForm
          appointmentId={appointmentId}
          loading={false}
          steps={steps}
          onSuccess={onSuccess}
        />
      </MemoryRouter>
    );
    expect(
      screen.getByText(`Question 1 of ${steps.length}`)
    ).toBeInTheDocument();
    expect(screen.queryByTestId("next-btn")).not.toBeInTheDocument();
    expect(screen.queryByTestId("submit-btn")).toBeInTheDocument();
  });

  it("renders next/prev questions when next/prev buttons are clicked", () => {
    const appointmentId = "";
    const steps = [
      {
        text: "Example",
        order: 1,
        questionType: QuestionType.Scale,
        questionId: "b5a8dbbe-9ef4-4df4-97bd-ff3ee78c874e",
        questionName: "Example",
      },
      {
        text: "Example 2",
        order: 2,
        questionType: QuestionType.Scale,
        questionId: "b5a8dbbe-9ef4-4df4-97bd-ee3ee78c874e",
        questionName: "Example 2",
      },
    ] as Array<StepData>;
    const onSuccess = (questionAnswers: QuestionAnswer[]) => {};
    const screen = renderWithClient(
      queryClient,
      <MemoryRouter>
        <FeedbackForm
          appointmentId={appointmentId}
          loading={false}
          steps={steps}
          onSuccess={onSuccess}
        />
      </MemoryRouter>
    );
    const nextButton = screen.getByText("Next");
    fireEvent.click(nextButton);

    expect(
      screen.getByText(`Question 2 of ${steps.length}`)
    ).toBeInTheDocument();

    const prevButton = screen.getByText("Previous");
    fireEvent.click(prevButton);

    expect(
      screen.getByText(`Question 1 of ${steps.length}`)
    ).toBeInTheDocument();
  });
});
