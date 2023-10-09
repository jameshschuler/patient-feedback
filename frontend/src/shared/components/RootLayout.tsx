import BackgroundImage from "@/assets/feedback_bg.jpg";
import { Outlet } from "react-router-dom";

export function RootLayout() {
  return (
    <>
      <img
        src={BackgroundImage}
        className="absolute h-full"
        style={{ zIndex: -1 }}
      />
      <main className="mx-auto p-6 md:p-12 md:max-w-screen-2xl">
        <Outlet />
      </main>
    </>
  );
}
