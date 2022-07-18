import { ReactNode } from "react";

export type CustomDatePickerProps = {
  placeholder?: string;
  description?: ReactNode;
  label?: ReactNode;
  labelFormat?: string;
  allowFreeInput?: boolean;
  clearable?: boolean;
  defaultValue: Date;
  value: Date;
  error?: ReactNode;
  required?: boolean;
  locale?: string;
  fullWidth?: boolean;
  excludeDate?(date: Date): boolean;
  onChange(value: Date): void;
};