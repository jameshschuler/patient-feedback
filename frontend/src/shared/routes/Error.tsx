import { useRouteError } from "react-router-dom";

export function Error() {
  const error = useRouteError() as Error;

  return (
    <main className="mx-auto p-12 max-w-screen-2xl">
      <div className="p-24 bg-white rounded-2xl mt-12">
        <h1 className="text-2xl">Oops!</h1>
        <p className="text-lg mt-2 mb-6">
          Sorry, an unexpected error has occurred.
        </p>
        <p className="bg-red-100 p-6 rounded-xl">
          <i>{error.message}</i>
        </p>
      </div>
    </main>
  );
}
