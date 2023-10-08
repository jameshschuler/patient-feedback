import { DefaultOptions, QueryClient } from "@tanstack/react-query";

const queryConfig: DefaultOptions = {
  queries: {
    refetchOnWindowFocus: false,
    retry: 1,
  },
};

export const queryClient = new QueryClient({ defaultOptions: queryConfig });
