import { Autocomplete, AutocompleteItem } from "@mantine/core";
import { CustomAutocompleteProps } from "./CustomAutocompleteProps";

export const CustomAutocomplete = ({
  data,
  dataKeyName,
  dataValueName,
  defaultValue,
  disabled,
  error,
  icon,
  label,
  nothingFound,
  required,
  size,
  value,
  description,
  onChange,
  onItemSubmit,
}: CustomAutocompleteProps) => {
  return (
    <Autocomplete
      data={
        data.map((x: any) => {
          return { key: x[dataKeyName], value: x[dataValueName] } || []
        })
      }
      defaultValue={defaultValue}
      disabled={disabled}
      error={error}
      icon={icon}
      label={label}
      nothingFound={nothingFound}
      required={required}
      size={size}
      value={value}
      description={description}
      onChange={onChange}
      onItemSubmit={onItemSubmit}
    />
  );
};