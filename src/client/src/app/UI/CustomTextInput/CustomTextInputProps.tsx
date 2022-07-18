import { InputVariant } from "@mantine/core";
import { ChangeEventHandler, ReactNode } from "react";

export type CustomTextInputProps = {
    placeholder?: string;
    required?: boolean;
    label?: ReactNode;
    description?: ReactNode;
    error?: ReactNode;
    disabled?: boolean;
    variant?: InputVariant;
    value?: string;
    size?: "xs" | "sm" | "md" | "lg" | "xl";
    type?: "number" | "search" | "text" | "tel" | "url" | "email" | "password";
    style?: React.CSSProperties | undefined;
    className?: string | undefined;
    onChange?: ChangeEventHandler<HTMLInputElement>;
}