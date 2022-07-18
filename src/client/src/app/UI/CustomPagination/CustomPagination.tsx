import { Pagination } from "@mantine/core";
import { CustomPaginationProps } from "./CustomPaginationProps";
import "./CustomPagination.css"

export const CustomPagination = ({
  align,
  boundaries,
  color,
  direction,
  grow,
  initialPage,
  noWrap,
  page,
  position,
  radius,
  siblings,
  size,
  spacing,
  total,
  withEdges,
  withControls,
  onChange,
  getItemAriaLabel,
}: CustomPaginationProps) => {
  return (
    <div className={'default-margin'}>
      <Pagination
        align={align}
        boundaries={boundaries}
        color={color}
        direction={direction}
        grow={grow}
        initialPage={initialPage}
        noWrap={noWrap}
        position={position}
        radius={radius}
        siblings={siblings}
        size={size}
        spacing={spacing}
        page={page}
        total={total}
        withControls={withControls}
        withEdges={withEdges}
        onChange={onChange}
        getItemAriaLabel={getItemAriaLabel}
      />
    </div>
  );
};
