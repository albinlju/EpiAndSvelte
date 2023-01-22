import type { ContentData } from './DataFetching';
import type { IImageBlock } from '../../Features/Svelte/Components/EpiserverBlocks/ImageBlock/IImageBlock';

export type Property = {
    value: string;
    propertyDataType: string;
}



export interface IPageData extends ContentData {
    title: Property;
    topImage: ITopImage;
    intro: Property
    blocks: {
        expandedValue:[
            IImageBlock
        ]
    }
}


export interface ITopImage {
    expandedValue: ITopImageExpanded;
    value: {
        guidValue: string;
        id: number;
        url: string;
        workId: number;
    }
}

export interface ITopImageExpanded extends ContentData {
    url: string;
    thumbnail: {
        value: {
            url: string;
        }
    }
}