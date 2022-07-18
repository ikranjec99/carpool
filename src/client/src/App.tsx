import React from "react";
import { MantineProvider } from "@mantine/core";
import { Navigation } from "./app/UI/Navigation/Navigation";
import { Router } from "./app/Router/Router";

import "./App.css";

const App = () => {
  return (
    <>
      <MantineProvider>
        <Navigation routerProps={Router} />
      </MantineProvider>
    </>
  );
};

export default App;
