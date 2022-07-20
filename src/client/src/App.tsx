import React from "react";
import { MantineProvider } from "@mantine/core";
import { Navigation } from "./app/UI/Navigation/Navigation";
import { Router } from "./app/Router/Router";

import "./App.css";
import GlobalContextProvider from "./app/Contexts/GlobalContext";

const App = () => {
  return (
    <>
      <MantineProvider>
        <GlobalContextProvider>
          <Navigation routerProps={Router} />
        </GlobalContextProvider>
      </MantineProvider>
    </>
  );
};

export default App;
