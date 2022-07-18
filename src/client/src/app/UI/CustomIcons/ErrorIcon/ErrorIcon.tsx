import { ErrorIconProps } from "./ErrorIconProps";
import { ReactComponent as CustomErrorIcon } from './error.svg';

export const ErrorIcon = ({ size }: ErrorIconProps) => {
    return <CustomErrorIcon style={{ width: size, height: size }} />
}