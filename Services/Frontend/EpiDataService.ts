import type { ContentData } from "../../Interfaces/Frontend/DataFetching";
import { __serviceHelper } from "./ServiceHelper";


class EpiDataService {
    
    constructor(){
        __serviceHelper.init("/api/episerver/v3.0/");
    }

    getContentById = async <T extends ContentData>(id: string, expanded?: boolean):Promise<T> => {
        try{
            const response = await __serviceHelper.get<T>(`content/${id}${expanded ? "?" + new URLSearchParams("expand=*") : ""}`); 
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