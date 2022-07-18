import { MantineShadow } from "@mantine/core";

export type CustomPaperProps = {
  component?: any;
  padding?: number | "xs" | "sm" | "md" | "lg" | "xl";
  shadow?: MantineShadow;
  withBorder?: boolean;
};
