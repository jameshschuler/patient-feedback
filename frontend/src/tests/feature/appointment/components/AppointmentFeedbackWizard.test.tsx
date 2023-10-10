import { useAppointmentFeedback } from "@/features/appointments/api/getAppointmentFeedback";
import { AppointmentFeedbackWizard } from "@/features/appointments/components/AppointmentFeedbackWizard";
import { queryClient } from "@/lib/react-query";
import { createWrapper, renderWithClient } from "@/tests/utils";
import { renderHook, waitFor } from "@testing-library/react";
import { describe, expect, it } from "vitest";

describe("AppointmentFeedbackWizard", () => {
  it("renders title", () => {
    const screen = renderWithClient(queryClient, <AppointmentFeedbackWizard />);
    expect(
      screen.getByText("Patient Appointment Feedback")
    ).toBeInTheDocument();
  });

  it("makes request to get appointment feedback questions", async () => {
    const appointmentId = "64f1b5a0-1f6e-4e59-ae95-a94b34e5619";
    const { result } = renderHook(
      () => useAppointmentFeedback({ appointmentId }),
      {
        wrapper: createWrapper(),
      }
    );
    await waitFor(() => expect(result.current.isSuccess).toBe(true));
    expect(result.current.data?.data.appointmentId).toBe("hello");
    expect(result.current.data?.data.questions).toBeDefined();
    expect(result.current.data?.data.questions.length).toBe(1);
  });
});
