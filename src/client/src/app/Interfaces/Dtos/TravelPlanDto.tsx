import { Car } from "../Models/Car";

export interface TravelPlanDto {
    id: string;
    car: Car;
    startDate: Date;
    endDate: Date;
    travelPlanStartLocation: string;
    travelPlanStartLocationId: string;
    travelPlanEndLocation: string;
    travelPlanEndLocationId: string;
}