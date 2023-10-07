import { MessageType } from "../types";

interface MessageProps {
  text?: string;
  messageType: MessageType;
}

export function Message({ text, messageType }: MessageProps) {
  return (
    <div>
      <p
        className={`p-6 rounded-xl ${
          messageType === MessageType.Error ? "bg-red-100" : "bg-blue-100"
        }`}
      >
        <i>{text ?? "Something went wrong while processing your request."}</i>
      </p>
      <button className="btn bg-slate-100 hover:bg-slate-300 mt-6">Home</button>
    </div>
  );
}
