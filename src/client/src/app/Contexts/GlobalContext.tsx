import { createContext, useState } from "react";

export const GlobalContext = createContext<any>({
});

const GlobalContextProvider = ( props: any ) => {
    const [isLoading, setIsLoading] = useState<boolean>(false);

    return  <GlobalContext.Provider value={{ isLoading, setIsLoading }}>{props.children}</GlobalContext.Provider>
}

export default GlobalContextProvider;