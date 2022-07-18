import { toast } from "react-toastify";

export class ToasterHelper {
    public static success(message: string) {
        toast.success(message);
    }

    public static error(message: string) {
        toast.error(message);
    }

    public static warn(message: string) {
        toast.warn(message);
    }

    public static info(message: string) {
        toast.info(message);
    }
}