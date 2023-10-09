import { useEffect, useState } from "react";
import { MessageType } from "../types";

interface MessageProps {
  text?: string;
  messageType: MessageType;
}

export function Message({ text, messageType }: MessageProps) {
  const [messageTypeStyle, setMessageTypeStyle] =
    useState<string>("bg-blue-100");

  useEffect(() => {
    switch (messageType) {
      case MessageType.Error:
        setMessageTypeStyle("bg-red-100");
        break;
      case MessageType.Success:
        setMessageTypeStyle("bg-green-100");
    }
  }, [messageType]);

  return (
    <div>
      <p className={`p-6 rounded-xl text-lg ${messageTypeStyle}`}>
        <i>{text ?? "Something went wrong while processing your request."}</i>
      </p>
    </div>
  );
}
