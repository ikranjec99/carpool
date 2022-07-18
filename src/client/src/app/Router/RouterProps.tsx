import { ReactNode } from "react";

export type RouterProps = {
    name: string;
    icon: ReactNode;
    route: string;
    component: ReactNode;
    visibleInNavigation: boolean;
    children?: RouterProps[];
}