import { Text } from "@mantine/core";
import { CustomTextProps } from "./CustomTextProps";

export const CustomText = ({
  align,
  color,
  gradient,
  inline,
  lineClamp,
  size,
  transform,
  underline,
  variant,
  weight,
  children,
  style
}: CustomTextProps) => {
  return (
    <Text
      align={align}
      color={color}
      gradient={gradient}
      inline={inline}
      lineClamp={lineClamp}
      size={size}
      transform={transform}
      underline={underline}
      variant={variant}
      weight={weight}
      children={children}
      style={style}
    />
  );
};
