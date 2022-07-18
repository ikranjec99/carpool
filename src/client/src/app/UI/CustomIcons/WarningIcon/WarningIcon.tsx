import { ReactComponent as CustomWarningIcon } from "./warning.svg";
import { WarningIconProps } from "./WarningIconProps";

export const WarningIcon = ({ size }: WarningIconProps) => {
  return <CustomWarningIcon style={{ width: size, height: size }} />;
};
