import { useEffect } from "react";
import { CustomTitle } from "../../UI/CustomTitle/CustomTitle";
import { HomeProps } from "./HomeProps";

export const Home = ({ description }: HomeProps) => {
    useEffect(() => {
        console.log(process.env.PUBLIC_URL)
    }, [])

    return <CustomTitle>{description}</CustomTitle>
}