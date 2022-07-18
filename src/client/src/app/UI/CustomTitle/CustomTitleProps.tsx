import { TitleOrder } from "@mantine/core";
import { ReactNode } from "react";

export type CustomTitleProps = {
    align?: "left" | "right" | "center" | "justify";
    order?: TitleOrder;
    children: ReactNode;
}