import { EventIconProps } from './EventIconProps';
import { ReactComponent as CustomEventIcon } from './event-icon.svg';

export const EventIcon = ({ size }: EventIconProps) => {
    return <CustomEventIcon style={{ width: size, height: size }} />
}