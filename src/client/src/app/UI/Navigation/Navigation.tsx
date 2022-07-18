import { NavigationProps } from "./NavigationProps";
import { Route, Routes, useNavigate } from "react-router-dom";
import "./Navigation.css";
import { RouterProps } from "../../Router/RouterProps";
import {
  AppShell,
  Burger,
  Header,
  MediaQuery,
  Navbar,
  useMantineTheme,
} from "@mantine/core";
import { useState } from "react";
import { NavigationItem } from "./NavigationItem/NavigationItem";
import { NavigationHeader } from "./NavigationHeader/NavigationHeader";
import { EventIcon } from "../CustomIcons/EventIcon/EventIcon";
import { CustomToastContainer } from "../CustomToastContainer/CustomToastContainer";
import { NotFound } from "../NotFound/NotFound";

export const Navigation = ({ routerProps }: NavigationProps) => {
  const [opened, setOpened] = useState(false);
  const theme = useMantineTheme();
  const navigate = useNavigate();

  return (
    <>
      <AppShell
        navbarOffsetBreakpoint="sm"
        fixed
        navbar={
          <Navbar
            hiddenBreakpoint="sm"
            hidden={!opened}
            width={{ sm: 300, lg: 400 }}
          >
            {routerProps &&
              routerProps.filter((x: RouterProps) => x.visibleInNavigation).map((x: RouterProps) => {
                return (
                  <>
                    {!x.children && (
                      <NavigationItem
                        key={x.route}
                        icon={x.icon}
                        route={x.route}
                        placeholder={x.name}
                      />
                    )}

                    {x.children && (
                      <>
                        <NavigationItem
                          key={x.route}
                          icon={x.icon}
                          route={x.route}
                          placeholder={x.name}
                          menu={x.children}
                        />
                      </>
                    )}
                  </>
                );
              })}
          </Navbar>
        }
        header={
          <Header height={70}>
            <div
              style={{ display: "flex", alignItems: "center", height: "100%" }}
            >
              <MediaQuery largerThan="sm" styles={{ display: "none" }}>
                <Burger
                  opened={opened}
                  onClick={() => setOpened((o) => !o)}
                  size="sm"
                  color={theme.colors.gray[6]}
                  mr="xl"
                />
              </MediaQuery>
              <NavigationHeader
                label={"Carpool"}
                icon={<EventIcon size={20} />}
              />
            </div>
          </Header>
        }
      >
        <Routes>
          {routerProps.map((x: RouterProps) => {
            return (
              <>
                <Route key={x.route} path={x.route} element={x.component} />
                {x.children && (
                    <Route key={x.route} path={x.route} element={x.component} />
                  ) &&
                  x.children.map((r: RouterProps) => {
                    return (
                      <Route
                        key={r.route}
                        path={r.route}
                        element={r.component}
                      />
                    );
                  })}
              </>
            );
          })}
          <Route key={'not-found'} path={'*'} element={<NotFound onBackButtonClick={() => navigate('/')} text={"Oops - we've looked everywhere and could not find this."}/>} />
        </Routes>
        <CustomToastContainer
          position="bottom-right"
          autoClose={5000}
          hideProgressBar={false}
          newestOnTop={false}
          closeOnClick
          rtl={false}
          pauseOnFocusLost
          draggable
          pauseOnHover
          theme={"dark"}
        />
      </AppShell>
    </>
  );
};
