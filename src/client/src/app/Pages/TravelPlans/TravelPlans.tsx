import { useContext, useState } from "react"
import { GlobalContext } from "../../Contexts/GlobalContext"
import { PagedCollection } from "../../Interfaces/Common/PagedCollection/PagedCollection";
import { TravelPlanDto } from "../../Interfaces/Dtos/TravelPlanDto";

export const TravelPlans = () => {
    const { isLoading, setIsLoading } = useContext(GlobalContext)
    const [page, setPage] = useState<number>(1);
    const [take, setTake] = useState<number>(10);
    const [travelPlans, setTravelPlans] = useState<PagedCollection<TravelPlanDto>>();

    return (
        <>travel plans</>
    )
}