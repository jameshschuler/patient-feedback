import { useAppointmentFeedback } from "@/features/appointments/api/getAppointmentFeedback";
import { AppointmentFeedbackWizard } from "@/features/appointments/components/AppointmentFeedbackWizard";
import { queryClient } from "@/lib/react-query";
import { createWrapper, renderWithClient } from "@/tests/utils";
import { renderHook, waitFor } from "@testing-library/react";
import nock from "nock";
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
    const scope = nock("https://localhost:7115/api/")
      .get(`/appointment/${appointmentId}/feedback`)
      .reply(200, {
        data: {
          appointmentId: appointmentId,
        },
      });
    const { result } = renderHook(
      () => useAppointmentFeedback({ appointmentId }),
      {
        wrapper: createWrapper(),
      }
    );
    await waitFor(() => {
      return result.current.isSuccess;
    });
    scope.done();
  });
});
