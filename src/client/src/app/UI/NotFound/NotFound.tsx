import { Center } from "@mantine/core";
import { SearchIcon } from "../CustomIcons/SearchIcon/SearchIcon";
import { NotFoundProps } from "./NotFoundProps";
import "./NotFound.css";
import { CustomButton } from "../CustomButton/CustomButton";

export const NotFound = ({ text, onBackButtonClick }: NotFoundProps) => {
  return (
    <>
      <div className={"main-container"}>
        <Center>
          <SearchIcon size={80} />
        </Center>
      </div>
      <Center>
        <div className={'text mg-top'}>{text}</div>
      </Center>
      <Center>
        <div className={'mg-top'}>
          <CustomButton color={'blue'} size={'md'} type={'button'} onClick={onBackButtonClick} children={"Return to homepage"} />
        </div>
      </Center>
    </>
  );
};
