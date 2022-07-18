import { MantineShadow, MantineTransition } from "@mantine/core";
import { ReactNode } from "react";

export type CustomModalProps = {
    id?: string;
    centered?: boolean;
    closeButtonLabel?: string;
    closeOnClickOutside?: boolean;
    closeOnEscape?: boolean;
    opened: boolean;
    overflow?: "inside" | "outside"
    overlayColor?: 'string';
    padding?: number | "xs" | "sm" | "md" | "lg" | "xl";
    radius?: number | "xs" | "sm" | "md" | "lg" | "xl";
    shadow?: MantineShadow;
    size?: string | number;
    target?: string | HTMLElement;
    title?: ReactNode;
    transition?: MantineTransition;
    transitionDuration?: number;
    transitionTimingFunction?: string;
    trapFocus?: boolean;
    withCloseButton?: boolean;
    withinPortal?: boolean;
    zIndex?: number;
    children: ReactNode;
    onClose: () => void;
}