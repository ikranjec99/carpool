import { SuccessIconProps } from "./SuccessIconProps";
import { ReactComponent as CustomSuccessIcon } from './success.svg';

export const SuccessIcon = ({ size }: SuccessIconProps) => {
    return <CustomSuccessIcon style={{ width: size, height: size }} />
}