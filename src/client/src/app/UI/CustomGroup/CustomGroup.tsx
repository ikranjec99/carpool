import { Group } from "@mantine/core";
import { CustomGroupProps } from "./CustomGroupProps";

export const CustomGroup = ({
  align,
  direction,
  grow,
  noWrap,
  position,
  spacing,
  children,
}: CustomGroupProps) => {
  return (
    <Group
      align={align}
      direction={direction}
      grow={grow}
      noWrap={noWrap}
      position={position}
      spacing={spacing}
      children={children}
    />
  );
};