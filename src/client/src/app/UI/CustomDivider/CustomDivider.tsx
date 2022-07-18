import { Divider } from "@mantine/core";
import { CustomDividerProps } from "./CustomDividerProps";

export const CustomDivider = ({
  color,
  label,
  labelPosition,
  labelProps,
  orientation,
  size,
  variant,
}: CustomDividerProps) => {
  return (
    <Divider
      color={color}
      label={label}
      labelPosition={labelPosition}
      labelProps={labelProps}
      orientation={orientation}
      size={size}
      variant={variant}
    />
  );
};