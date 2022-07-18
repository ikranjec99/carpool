import { ReactNode } from "react";
import { RouterProps } from "../../../Router/RouterProps";

export type NavigationItemProps = {
    icon: ReactNode;
    route: string;
    placeholder: string;
    menu?: RouterProps[];
}
