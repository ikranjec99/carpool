
import { RouterProps } from "./RouterProps";
import { AddIcon } from "../UI/CustomIcons/AddIcon/AddIcon";
import { ListIcon } from "../UI/CustomIcons/ListIcon/ListIcon";
import { HomeIcon } from "../UI/CustomIcons/HomeIcon/HomeIcon";
import { EditIcon } from "../UI/CustomIcons/EditIcon/EditIcon";

export const Router : RouterProps[] = [
  {
    name: "Home",
    icon: <HomeIcon size={20}/>,
    route: "",
    component: <>Welcome home!</>,
    visibleInNavigation: true
  },
  {
    name: "Activities",
    icon: <ListIcon />,
    route: "/activities",
    component: <>Activities</>,
    visibleInNavigation: true,
    children: [
      {
        name: "Create activity",
        icon: <AddIcon/>,
        route: "/activities/editor",
        component: <>Activities editor</>,
        visibleInNavigation: true
      },
      {
        name: "Edit activity",
        icon: <EditIcon/>,
        route: "/activities/editor/:activityId",
        visibleInNavigation: false,
        component: <>Edit activity</>
      }
    ]
  }
];