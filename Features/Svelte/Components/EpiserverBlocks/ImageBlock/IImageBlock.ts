import type { ContentData } from '../../../../../Interfaces/Frontend/DataFetching';

export interface IImageBlock extends ContentData {
    url: string;
    image:{
        value: {
            url: string;
        }
    }
}