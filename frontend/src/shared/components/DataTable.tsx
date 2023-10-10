interface DataTableProps<T> {
  data: T[];
  title: string;
  render: (item: T) => React.ReactNode;
}

export function DataTable<T>({ data, render, title }: DataTableProps<T>) {
  return (
    <div className="md:p-24 p-6 bg-white rounded-2xl mt-12 shadow-lg">
      <h1 className="text-3xl mb-8">{title}</h1>
      {data.map(render)}
    </div>
  );
}
