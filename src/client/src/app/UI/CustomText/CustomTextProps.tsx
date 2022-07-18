import { MantineColor, MantineGradient } from "@mantine/core";
import { ReactNode } from "react";

export type CustomTextProps = {
    align?: "left" | "right" | "center" | "justify";
    color?: MantineColor;
    gradient?: MantineGradient;
    inline?: boolean;
    lineClamp?: number;
    size?: "xs" | "sm" | "md" | "lg" | "xl";
    transform?: "none" | "capitalize" | "uppercase" | "lowercase";
    underline?: boolean;
    variant?: "link" | "text" | "gradient";
    weight?: any;
    children?: ReactNode;
    style?: React.CSSProperties | undefined;
}