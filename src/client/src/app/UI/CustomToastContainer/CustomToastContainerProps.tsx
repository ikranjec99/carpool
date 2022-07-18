import { ReactNode } from "react";
import { DraggableDirection, Theme, ToastPosition, ToastTransition } from "react-toastify";

export type CustomToastContainerProps = {
  position?: ToastPosition | undefined;
  autoClose?: number | false | undefined;
  closeButton?:boolean | React.ReactElement<any, string | React.JSXElementConstructor<any>> | ((props: any) => React.ReactElement<any, string | React.JSXElementConstructor<any>>) | undefined
  transition?: ToastTransition | undefined;
  hideProgressBar?: boolean;
  pauseOnHover?: boolean;
  pauseOnFocusLost?: boolean;
  rtl?: boolean;
  closeOnClick?: boolean;
  newestOnTop?: boolean;
  className?: string;
  style?: object;
  toastClassName?: string;
  bodyClassName?: string;
  progressClassName?: string;
  progressStyle?: object;
  draggable?: boolean;
  draggablePercent?: number;
  dragabbleDirection?: DraggableDirection | undefined;
  enableMultiContainer?: boolean;
  containerId?: string | number;
  limit?: number;
  role?: string;
  theme?: Theme | undefined;
};
