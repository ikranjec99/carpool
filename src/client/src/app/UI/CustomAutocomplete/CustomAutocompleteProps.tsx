import { AutocompleteItem } from "@mantine/core";
import { ReactNode } from "react";

export type CustomAutocompleteProps = {
    data: any;
    dataKeyName: string;
    dataValueName: string;
    description?: ReactNode;
    defaultValue?: string;
    disabled?: boolean;
    error?: ReactNode;
    icon?: ReactNode;
    label?: ReactNode;
    nothingFound?: ReactNode;
    required?: boolean;
    size?: "xs" | "sm" | "md" | "lg" | "xl";
    value?: string;
    onChange?(value: string): void;
    onItemSubmit(item: AutocompleteItem): void;
}