import { CustomTableProps } from "./CustomTableProps";
import { Table } from "@mantine/core";
import { CustomTableCell } from "./CustomTableCell";
import { CustomPagination } from "../CustomPagination/CustomPagination";
import "./CustomTable.css";
import { TableCellHelper } from "../../Helpers/TableCellHelper/TableCellHelper";
import { NoData } from "../NoData/NoData";
import { CustomLoader } from "../CustomLoader/CustomLoader";

export const CustomTable = ({
  captionSide,
  highlightOnHover,
  horizontalSpacing,
  verticalSpacing,
  striped,
  data,
  rows,
  pagination,
  total,
  currentPage,
  isLoading,
  onPageChange,
  onRowClick
}: CustomTableProps) => {
  const tableRows = (
    <tr>
      {rows &&
        rows.map((x: CustomTableCell) => {
          return <th>{x.label}</th>
        })}
    </tr>
  );

  const tableDataRows =
    data &&
    data.map((x: any) => {
      return (
        <tr onClick={() => onRowClick && onRowClick(x)} className={"row-pointer"}>
          {rows &&
            rows.map((y: CustomTableCell) => {
              return TableCellHelper.getTableCellData(x, y);
            })}
        </tr>
      );
    });

  return (
    <>
      <Table
        captionSide={captionSide}
        highlightOnHover={highlightOnHover}
        horizontalSpacing={horizontalSpacing}
        verticalSpacing={verticalSpacing}
        striped={striped}
      >
        {isLoading && <CustomLoader visible />}
        {!data && <NoData text={"No data"} />}
        {rows && data && <thead>{tableRows}</thead>}
        {rows && data && <tbody>{tableDataRows}</tbody>}
      </Table>
      
      {pagination && total && (
        <div className={'float-rt'}>
          <CustomPagination
            align={"flex-end"}
            page={currentPage}
            total={total}
            radius={'xl'}
            onChange={onPageChange}
          />
        </div>
      )}
    </>
  );
};
