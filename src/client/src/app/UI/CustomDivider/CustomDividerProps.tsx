import { MantineColor } from "@mantine/core";
import { ReactNode } from "react";

export type CustomDividerProps = {
    color: MantineColor;
    label?: ReactNode;
    labelPosition?: "left" | "right" | "center";
    labelProps?: Record<string, any>
    orientation?: "horizontal" | "vertical";
    size?: number | "xs" | "sm" | "md" | "lg" | "xl";
    variant?: "dashed" | "dotted" | "solid";
}