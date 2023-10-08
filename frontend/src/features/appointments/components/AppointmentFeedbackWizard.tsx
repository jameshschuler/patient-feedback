import { Message } from "@/shared";
import { MessageType } from "@/shared/types";
import { useEffect, useState } from "react";
import { useParams } from "react-router-dom";
import { useAppointmentFeedback } from "../api/getAppointmentFeedback";
import { Question } from "../types";
import { FeedbackForm } from "./FeedbackForm";

export function AppointmentFeedbackWizard() {
  const { appointmentId } = useParams();
  const { data, isLoading, isError, error } = useAppointmentFeedback({
    appointmentId,
  });

  const [steps, setSteps] = useState<Question[]>([]);

  useEffect(() => {
    setSteps(data?.data?.questions ?? []);
  }, [data?.data?.questions, isLoading]);

  return (
    <div className="p-24 bg-white rounded-2xl mt-12 shadow-lg">
      {isError && (
        <Message messageType={MessageType.Error} text={error as string} />
      )}
      {!isError && (
        <div>
          <FeedbackForm
            appointmentId={appointmentId!}
            loading={isLoading}
            steps={steps}
          ></FeedbackForm>
        </div>
      )}
    </div>
  );
}
