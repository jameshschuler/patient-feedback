import { Outlet } from "react-router-dom";

export function RootLayout() {
  return (
    <>
      <main className="mx-auto p-12 max-w-screen-2xl">
        <Outlet />
      </main>
    </>
  );
}
