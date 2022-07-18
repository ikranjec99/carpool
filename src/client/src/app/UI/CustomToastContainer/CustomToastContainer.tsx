import { ToastContainer } from "react-toastify";
import { CustomToastContainerProps } from "./CustomToastContainerProps";

export const CustomToastContainer = ({
  position,
  autoClose,
  closeButton,
  transition,
  hideProgressBar,
  pauseOnHover,
  pauseOnFocusLost,
  rtl,
  closeOnClick,
  newestOnTop,
  className,
  style,
  toastClassName,
  bodyClassName,
  progressClassName,
  progressStyle,
  draggable,
  draggablePercent,
  dragabbleDirection,
  enableMultiContainer,
  containerId,
  limit,
  role,
  theme,
}: CustomToastContainerProps) => {
  return (
    <ToastContainer
      position={position}
      autoClose={autoClose}
      closeButton={closeButton}
      transition={transition}
      hideProgressBar={hideProgressBar}
      pauseOnHover={pauseOnHover}
      pauseOnFocusLoss={pauseOnFocusLost}
      rtl={rtl}
      closeOnClick={closeOnClick}
      newestOnTop={newestOnTop}
      className={className}
      style={style}
      toastClassName={toastClassName}
      bodyClassName={bodyClassName}
      progressClassName={progressClassName}
      progressStyle={progressStyle}
      draggable={draggable}
      draggablePercent={draggablePercent}
      draggableDirection={dragabbleDirection}
      enableMultiContainer={enableMultiContainer}
      containerId={containerId}
      limit={limit}
      role={role}
      theme={theme}
    />
  );
};
