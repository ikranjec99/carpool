import { CustomLabelProps } from "./CustomLabelProps";
import "./CustomLabel.css";

export const CustomLabel = ({ value }: CustomLabelProps) => {
    return <span><b className={'custom-label-font'}>{value}</b></span>
}