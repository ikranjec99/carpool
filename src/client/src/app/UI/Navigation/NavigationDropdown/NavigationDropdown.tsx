import { Menu } from "@mantine/core";
import { useNavigate } from "react-router-dom";
import { RouterProps } from "../../../Router/RouterProps";
import { NavigationDropdownProps } from "./NavigationDropdownProps";

export const NavigationDropdown = ({
  label,
  trigger,
  routerChildren,
}: NavigationDropdownProps) => {
  const navigate = useNavigate();
  return (
    <Menu trigger={trigger}>
      <Menu.Label>{label}</Menu.Label>
      {routerChildren &&
        routerChildren.filter(x => x.visibleInNavigation).map((x: RouterProps) => {
          return (
            <Menu.Item
              key={x.route}
              onClick={() => navigate(x.route)}
              icon={x.icon}
            >
              {x.name}
            </Menu.Item>
          );
        })}
    </Menu>
  );
};
