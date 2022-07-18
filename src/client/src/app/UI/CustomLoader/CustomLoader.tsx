import { Loader, LoadingOverlay } from "@mantine/core";
import { CustomLoaderProps } from "./CustomLoaderProps";

export const CustomLoader = ({ color, size, variant, visible }: CustomLoaderProps ) => {
    return <LoadingOverlay visible={visible} loader={<Loader color={color} size={size} variant={variant} />} />
}