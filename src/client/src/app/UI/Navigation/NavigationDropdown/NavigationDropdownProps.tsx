import { RouterProps } from "../../../Router/RouterProps";

export type NavigationDropdownProps = {
    label: string;
    trigger?: "hover" | "click";
    routerChildren: RouterProps[];
}