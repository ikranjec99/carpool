import { County } from "./County";

export interface City {
  id: string;
  name: string;
  county: County;
  countyId: number;
  createdAt?: Date;
  updatedAt?: Date;
  deletedAt?: Date;
}
