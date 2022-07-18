import { Title } from "@mantine/core"
import { CustomTitleProps } from "./CustomTitleProps"

export const CustomTitle = ({ align, order, children }: CustomTitleProps) => {
    return <Title children={children} align={align} order={order} />
}