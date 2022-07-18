import { HomeIconProps } from "./HomeIconProps";
import { ReactComponent as CustomHomeIcon } from './home-icon.svg';

export const HomeIcon = ({ size }: HomeIconProps) => {
    return <CustomHomeIcon style={{ width: size, height: size}} />
}