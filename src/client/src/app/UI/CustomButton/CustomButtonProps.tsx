import { MantineColor, MantineGradient } from "@mantine/core";
import { ReactNode } from "react";

export type CustomButtonProps = {
    children?: ReactNode;
    color?: MantineColor;
    compact?: boolean;
    fullWidth?: boolean;
    gradient?: MantineGradient;
    leftIcon?: ReactNode;
    rightIcon?: ReactNode;
    loaderPosition?: 'left' | 'right';
    loading?: boolean;
    radius?: number | "xs" | "sm" | "md" | "lg" | "xl";
    size?: "xs" | "sm" | "md" | "lg" | "xl";
    type?: "button" | "reset" | "submit";
    style?: React.CSSProperties | undefined;
    className?: string | undefined;
    onClick?: React.MouseEventHandler<HTMLButtonElement> | undefined;
}