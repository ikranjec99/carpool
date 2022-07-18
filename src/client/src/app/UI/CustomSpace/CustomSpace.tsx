import { Space } from "@mantine/core"
import { CustomSpaceProps } from "./CustomSpaceProps"

export const CustomSpace = ({ height, width }: CustomSpaceProps) => {
    return <Space w={width} h={height} />
}