import { PaginationProps } from "@mantine/core";

export type CustomPaginationProps = {
    align?: 'baseline' | 'center' | 'end' | 'flex-end' | 'flex-start' | 'normal' | 'stretch';
    boundaries?: number;
    color?: PaginationProps["color"];
    direction?: "row" | "column";
    grow?: boolean;
    initialPage?: number;
    noWrap?: boolean;
    position?: "right" | "center" | "left" | "apart";
    radius?: number | "xs" | "sm" | "md" | "lg" | "xl";
    siblings?: number;
    size?: number | "xs" | "sm" | "md" | "lg" | "xl";
    spacing?: number | "xs" | "sm" | "md" | "lg" | "xl";
    page?: number;
    total: number;
    withControls?: boolean;
    withEdges?: boolean;
    onChange?: (page: number) => void;
    getItemAriaLabel?: (page: number | "dots" | "first" | "last" | "next" | "prev") => string;
}