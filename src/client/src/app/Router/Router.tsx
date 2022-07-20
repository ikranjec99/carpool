
import { RouterProps } from "./RouterProps";
import { AddIcon } from "../UI/CustomIcons/AddIcon/AddIcon";
import { ListIcon } from "../UI/CustomIcons/ListIcon/ListIcon";
import { HomeIcon } from "../UI/CustomIcons/HomeIcon/HomeIcon";
import { EditIcon } from "../UI/CustomIcons/EditIcon/EditIcon";
import { Home } from "../Pages/Home/Home";
import { TravelPlans } from "../Pages/TravelPlans/TravelPlans";

export const Router : RouterProps[] = [
  {
    name: "Home",
    icon: <HomeIcon size={20}/>,
    route: "",
    component: <Home description="Welcome home!" />,
    visibleInNavigation: true
  },
  {
    name: "Travel plans",
    icon: <ListIcon />,
    route: "/travel-plans",
    component: <TravelPlans />,
    visibleInNavigation: true
  }
];