import { CarMake } from "./CarMake";
import { Color } from "./Color";

export interface Car {
  id: string;
  name: string;
  carMake: CarMake;
  carModel: string;
  color: Color;
  plates: string;
  numberOfSeats: number;
  createdAt?: Date;
  updatedAt?: Date;
  deletedAt?: Date;
}
