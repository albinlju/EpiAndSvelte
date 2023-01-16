import type { ContentData } from "../../Interfaces/Frontend/DataFetching";
import { __serviceHelper } from "./ServiceHelper";


class EpiDataService {
    
    constructor(){
        __serviceHelper.init("https://localhost:5000/api/episerver/v3.0/");
    }

    GetContentById = async <T extends ContentData>(id: string):Promise<T> => {
        try{
            const response = await __serviceHelper.get<T>(`content/${id}`); 
            return response
        }catch(error){
            throw new Error("Kunde inte hämta alla produkter");
        }
    };
}

declare global {
    interface Window { Epi: any; }
}

const __epiDataService = new EpiDataService();

window.Epi = __epiDataService;
export { __epiDataService };