import moment from "moment";
import { ReactNode } from "react";
import { CustomTableCell } from "../../UI/CustomTable/CustomTableCell";
import { TextHelper } from "../TextHelper/TextHelper";

export class TableCellHelper {
    public static getTableCellData(data:any, cell: CustomTableCell) : ReactNode {
        if (cell.isDateTime) {
            return <td>{moment(data[(cell.key)]).format("DD.MM.YYYY.")}</td>;
        }

        if (cell.isHtmlContent) {
            return <td><div dangerouslySetInnerHTML={{ __html: TextHelper.cutText(data[cell.key], 400) }} /></td>
        }

        if (cell.key) {
            return <td>{TextHelper.cutText(data[cell.key], 60)}</td>
        }
    }
}