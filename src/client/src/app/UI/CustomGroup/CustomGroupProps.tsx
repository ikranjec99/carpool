import { ReactNode } from "react";

export type CustomGroupProps = {
    align?: AlignSetting;
    direction?: "row" | "column";
    grow?: boolean;
    noWrap?: boolean;
    position?: "right" | "center" | "left" | "apart";
    spacing?: number | "xs" | "sm" | "md" | "lg" | "xl";
    children?: ReactNode;
}