import axios, { AxiosError, AxiosInstance, AxiosResponse } from "axios";
import { toast } from "react-toastify";

declare module "axios" {
  interface AxiosResponse<T = any> extends Promise<T> {}
}

export abstract class HttpClient {
  protected readonly instance: AxiosInstance;

  public constructor(baseURl: string) {
    this.instance = axios.create({
      baseURL: baseURl,
    });

    this.instance.interceptors.response.use((response: AxiosResponse<any>) => {
      return response;
    }, (error: AxiosError<any>) => {
      const errMessage = error.response?.data.title ?? error.message;
      toast.error(`Error: ${errMessage}`);
      return Promise.reject(error)
    });
  }
}