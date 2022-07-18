import { Button } from "@mantine/core";
import { CustomButtonProps } from "./CustomButtonProps";

export const CustomButton = ({
  color,
  compact,
  fullWidth,
  gradient,
  leftIcon,
  rightIcon,
  loaderPosition,
  loading,
  radius,
  size,
  type,
  children,
  style,
  className,
  onClick
}: CustomButtonProps) => {
  return <Button 
  color={color}
  compact={compact}
  fullWidth={fullWidth}
  gradient={gradient}
  leftIcon={leftIcon}
  rightIcon={rightIcon}
  loaderPosition={loaderPosition}
  loading={loading}
  radius={radius}
  size={size}
  type={type}
  onClick={onClick} 
  children={children}
  style={style}
  className={className}
  />;
};