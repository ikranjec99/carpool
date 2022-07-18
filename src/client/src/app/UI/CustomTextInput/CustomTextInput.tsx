import { TextInput } from "@mantine/core";
import { CustomTextInputProps } from "./CustomTextInputProps";

export const CustomTextInput = ({
  placeholder,
  label,
  description,
  error,
  disabled,
  variant,
  size,
  type,
  value,
  required,
  style,
  className,
  onChange
}: CustomTextInputProps) => {
  return (
    <TextInput
      placeholder={placeholder}
      label={label}
      description={description}
      error={error}
      disabled={disabled}
      variant={variant}
      size={size}
      type={type}
      value={value}
      required={required}
      style={style}
      className={className}
      onChange={onChange}
    />
  );
};
