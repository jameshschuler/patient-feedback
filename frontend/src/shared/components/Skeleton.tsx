import { ReactNode } from "react";

interface SkeletonProps {
  children: ReactNode;
  loading: boolean;
  height?: string;
}

export function Skeleton({ children, height, loading }: SkeletonProps) {
  return (
    <>
      {loading && <div className={`loadable ${height ?? "h-6"}`}></div>}
      {!loading && children}
    </>
  );
}
