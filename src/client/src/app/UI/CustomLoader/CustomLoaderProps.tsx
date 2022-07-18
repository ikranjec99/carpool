import { MantineColor } from "@mantine/core";
import { LoaderType } from "@mantine/styles/lib/theme/types/MantineTheme";

export type CustomLoaderProps = {
    color?: MantineColor;
    size?: number | "xs" | "sm" | "md" | "lg" | "xl";
    variant?: LoaderType;
    visible: boolean;
}