import { Center } from "@mantine/core";
import { NoDataProps } from "./NoDataProps";

export const NoData = ({ text }: NoDataProps) => {
  return <Center children={text} />;
};
