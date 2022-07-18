import { ReactComponent as Icon } from "./search.svg";
import { SearchIconProps } from "./SearchIconProps";

export const SearchIcon = ({ size }: SearchIconProps) => {
  return <Icon width={size} height={size} />;
};
