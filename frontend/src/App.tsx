import { AppointmentFeedback, Appointments } from "@/features/appointments";
import { Error, RootLayout } from "@/shared";
import {
  Route,
  RouterProvider,
  createBrowserRouter,
  createRoutesFromElements,
} from "react-router-dom";

const router = createBrowserRouter(
  createRoutesFromElements(
    <Route path="/" element={<RootLayout />} errorElement={<Error />}>
      <Route path="/appointments" element={<Appointments />}></Route>
      <Route
        path="/appointments/:appointmentId/feedback"
        element={<AppointmentFeedback />}
      ></Route>
    </Route>
  )
);

function App() {
  return <RouterProvider router={router} />;
}

export default App;
