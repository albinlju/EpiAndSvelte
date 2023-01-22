import type { ContentData } from './DataFetching';
import type { ITopImage } from './types';

export type Property = {
    value: string;
    propertyDataType: string;
}

export interface IImagBlock extends ContentData {
    url: string;
    image:{
        value: {
            url: string;
        }
    }
}

export interface IPageData extends ContentData {
    title: Property;
    topImage: ITopImage;
    intro: Property
    blocks: {
        expandedValue:[
            IImagBlock
        ]
    }
}
