import { Paper } from "@mantine/core";
import { CustomPaperProps } from "./CustomPaperProps";

export const CustomPaper = ({ component, padding, shadow, withBorder }: CustomPaperProps) => {
    return <Paper component={component} padding={padding} shadow={shadow} withBorder={withBorder} />
}