import { Modal } from "@mantine/core";
import { CustomModalProps } from "./CustomModalProps";

export const CustomModal = ({
  id,
  centered,
  closeButtonLabel,
  closeOnClickOutside,
  closeOnEscape,
  opened,
  overflow,
  overlayColor,
  padding,
  radius,
  shadow,
  size,
  target,
  title,
  transition,
  transitionDuration,
  transitionTimingFunction,
  zIndex,
  children,
  onClose
}: CustomModalProps) => {
  return <Modal
    id={id}
    centered={centered}
    closeButtonLabel={closeButtonLabel}
    closeOnClickOutside={closeOnClickOutside}
    closeOnEscape={closeOnEscape}
    opened={opened}
    overflow={overflow}
    overlayColor={overlayColor}
    padding={padding}
    radius={radius}
    shadow={shadow}
    size={size}
    target={target}
    title={title}
    transition={transition}
    transitionDuration={transitionDuration}
    transitionTimingFunction={transitionTimingFunction}
    zIndex={zIndex}
    children={children}
    onClose={onClose}
   />;
};
