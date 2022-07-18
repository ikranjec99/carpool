import { DatePicker } from "@mantine/dates";
import { CustomDatePickerProps } from "./CustomDatePickerProps";

export const CustomDatePicker = ({
  allowFreeInput,
  clearable,
  defaultValue,
  value,
  error,
  fullWidth,
  label,
  labelFormat,
  placeholder,
  required,
  locale,
  description,
  excludeDate,
  onChange,
}: CustomDatePickerProps) => {
  return (
    <DatePicker
      allowFreeInput={allowFreeInput}
      clearable={clearable}
      defaultValue={defaultValue}
      value={value}
      error={error}
      fullWidth={fullWidth}
      label={label}
      labelFormat={labelFormat}
      placeholder={placeholder}
      required={required}
      locale={locale}
      description={description}
      excludeDate={excludeDate}
      onChange={onChange}
    />
  );
};