import { RichTextEditorLabels } from "@mantine/rte";
import { ReactNode } from "react";

export type CustomTextEditorProps = {
  error?: ReactNode;
  value: string;
  required?: boolean;
  labels?: RichTextEditorLabels;
  customLabel: string;
  customDescription?: string;
  onChange(value: string): void;
};
