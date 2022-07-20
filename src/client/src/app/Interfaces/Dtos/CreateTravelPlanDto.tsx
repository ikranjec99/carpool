export interface CreateTravelPlanDto {
  carId: string;
  startDate: Date;
  endDate: Date;
  startLocationId: string;
  endLocationId: string;
  employees: Array<string>;
}
