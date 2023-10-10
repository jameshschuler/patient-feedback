import react from "@vitejs/plugin-react";
import path from "path";
/// <reference types="vitest" />
import { defineConfig } from "vite";

import type { UserConfig as VitestUserConfigInterface } from "vitest/config";

const vitestConfig: VitestUserConfigInterface = {
  test: {
    globals: true,
    environment: "jsdom",
    setupFiles: "./src/tests/setup.ts",
  },
};

// https://vitejs.dev/config/
export default defineConfig({
  plugins: [react()],
  test: vitestConfig.test,
  resolve: {
    alias: [
      { find: "@", replacement: path.resolve(__dirname, "src") },
      {
        find: "@features",
        replacement: path.resolve(__dirname, "src/features"),
      },
    ],
  },
});
