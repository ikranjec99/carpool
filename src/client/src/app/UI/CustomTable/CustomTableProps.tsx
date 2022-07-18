import { CustomTableCell } from "./CustomTableCell";

export type CustomTableProps = {
  isLoading?: boolean;
  captionSide?: "bottom" | "top";
  fontSize?: number | "xs" | "sm" | "md" | "lg" | "xl" | undefined;
  highlightOnHover?: boolean;
  horizontalSpacing?: number | "xs" | "sm" | "md" | "lg" | "xl";
  striped?: boolean;
  verticalSpacing?: number | "xs" | "sm" | "md" | "lg" | "xl";
  data: any;
  rows: CustomTableCell[];
  pagination?: boolean;
  total?: number;
  currentPage?: number;
  onPageChange?: ((page: number) => void) | undefined;
  onRowClick?(data: any): void | undefined;
};
