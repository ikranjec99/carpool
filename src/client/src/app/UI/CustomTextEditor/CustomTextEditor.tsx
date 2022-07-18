import RichTextEditor from "@mantine/rte";
import { CustomLabel } from "../CustomLabel/CustomLabel";
import { CustomTextEditorProps } from "./CustomTextEditorProps";
import "./CustomTextEditor.css";
import { CustomDescription } from "../CustomDescription/CustomDescription";

export const CustomTextEditor = ({
  value,
  customLabel,
  customDescription,
  required,
  error,
  onChange,
}: CustomTextEditorProps) => {
  return (
    <span>
      <CustomLabel value={customLabel} />
      {required && <span className={'required-default'}>*</span>}
      {customDescription && <CustomDescription description={customDescription} />}
      <RichTextEditor
        controls={[
          ["bold", "italic", "underline", "link"],
          ["unorderedList", "h1", "h2", "h3"],
          ["sup", "sub"],
          ["alignLeft", "alignCenter", "alignRight"],
        ]}
        value={value}
        onChange={onChange}
        sticky
      />
      {error && <span className={'error-default'}>{error}</span> }
    </span>
  );
};
