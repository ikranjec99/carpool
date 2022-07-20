import { BaseApiUrl } from "../Constants/Url";
import { HttpClient } from "../HttpClient/AxiosInstance";
import { TravelPlanDto } from "../Interfaces/Dtos/TravelPlanDto";
import { PagedCollection } from "../Interfaces/Common/PagedCollection/PagedCollection";
import { CreateTravelPlanDto } from "../Interfaces/Dtos/CreateTravelPlanDto";
import { UpdateTravelPlanDto } from "../Interfaces/Dtos/UpdateTravelPlanDto";

export default class TravelPlanService extends HttpClient {
    private static instance?: TravelPlanService;

    private constructor() {
        super(BaseApiUrl);
    }

    public static getInstance() {
        if (!this.instance) {
            this.instance = new TravelPlanService();
        }

        return this.instance;
    }

    public getTravelPlans = async (page: number, take: number) => this.instance.get<PagedCollection<TravelPlanDto>>(`/travel-plan`, { params: { pageNumber: page, pageSize: take } });

    public getTravelPlan = async (id: string) => this.instance.get<TravelPlanDto>(`/travel-plan/${id}`);

    public deleteTravelPlan = async (id: string) => this.instance.delete(`/travel-plan`, { params: { travelPlanId: id } });

    public createTravelPlan = async (travelPlan: CreateTravelPlanDto) => this.instance.post(`/travel-plan`, travelPlan);

    public updateTravelPlan = async (travelPlan: UpdateTravelPlanDto) => this.instance.put(`/travel-plan`, travelPlan);
}