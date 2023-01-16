import axios from 'axios'
import type { AxiosResponse,  AxiosInstance,  AxiosRequestConfig,  CancelTokenSource } from 'axios';
import type { ContentData } from '../../Interfaces/Frontend/DataFetching';

interface apiService {
    init: (baseUrl: string) => void;
    get: <T extends ContentData>(url: string, config?: AxiosRequestConfig) => Promise<T>;
    post: <T>(url: string, data?:any, config?: AxiosRequestConfig) => Promise<T>;
    update: <T>(url: string, data?:any, config?: AxiosRequestConfig) => Promise<T>;
    delete: (url: string, config?: AxiosRequestConfig) => Promise<any>;
}

class Service implements apiService {

    private instance: AxiosInstance;
    cancelToken: CancelTokenSource

    constructor(){
        this.instance = axios.create({
            headers: {
                "Accept": "*/*",
                "Content-Type": "application/json",
                "Accept-Language": ""
            }
        });
        this.cancelToken = axios.CancelToken.source();
    }

    init = (baseUrl: string) => {
        this.instance.defaults.baseURL = baseUrl || '';
    }

    public get = async <T extends ContentData>(url: string, config?: AxiosRequestConfig): Promise<T> => {
        try{
            const response: AxiosResponse = await this.instance.get<T>(url, config);
            return response.data;
        }catch(error){
            console.log(error)
            return Promise.reject(error)
        }
       
    };

    public post = async <T>(url: string, data?:any, config?: AxiosRequestConfig): Promise<T> => {
        try{
            const response: AxiosResponse = await this.instance.post(url, data, config);
            return response.data;
        }catch(error){
            return Promise.reject(error);
        }
    };

    public update = async <T>(url: string, data?:any, config?: AxiosRequestConfig): Promise<T> => {
        try {
            const response: AxiosResponse = await this.instance.put(url, data, config);
            return response.data;
        } catch (error) {
            return Promise.reject(error);
        }
    }

    public delete = async (url:string, config?:AxiosRequestConfig): Promise<any> => {
        try {
            const response: AxiosResponse = await this.instance.delete(url, config);
            return response.data;
        } catch (error) {
            return Promise.reject(error);
        }
    }

}

const __serviceHelper = new Service();
export { __serviceHelper };