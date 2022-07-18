import { Group, Text, UnstyledButton } from "@mantine/core";
import { useNavigate } from "react-router-dom";
import { NavigationDropdown } from "../NavigationDropdown/NavigationDropdown";
import { NavigationItemProps } from "./NavigationItemProps";

export const NavigationItem = ({
  icon,
  route,
  placeholder,
  menu,
}: NavigationItemProps) => {
  const navigate = useNavigate();

  return (
    <UnstyledButton
      sx={(theme) => ({
        display: "block",
        width: "100%",
        padding: theme.spacing.md,
        color:
          theme.colorScheme === "dark" ? theme.colors.dark[0] : theme.black,

        "&:hover": {
          backgroundColor:
            theme.colorScheme === "dark"
              ? theme.colors.dark[8]
              : theme.colors.gray[0],
        },
      })}
    >
      <Group>
        <Group onClick={() => navigate(route)}>
          {icon}
          <div>
            <Text>{placeholder}</Text>
          </div>
        </Group>

        {menu && (
          <NavigationDropdown
            trigger={"hover"}
            label={placeholder}
            routerChildren={menu}
          />
        )}
      </Group>
    </UnstyledButton>
  );
};
