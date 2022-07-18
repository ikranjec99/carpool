import { Group, Text, UnstyledButton } from "@mantine/core";
import { NavigationHeaderProps } from "./NavigationHeaderProps";

export const NavigationHeader = ({ label, icon }: NavigationHeaderProps) => {
  return (
    <UnstyledButton>
      <Group>
        {icon}
        <div>
          <Text>{label}</Text>
        </div>
      </Group>
    </UnstyledButton>
  );
};
