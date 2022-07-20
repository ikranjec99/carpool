export interface UpdateTravelPlanDto {
  travelPlanId: string;
  carId: string;
  startDate: Date;
  endDate: Date;
  startLocationId: string;
  endLocationId: string;
  employees: Array<string>;
}
