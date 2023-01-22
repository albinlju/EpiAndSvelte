import type { ContentData } from './DataFetching';

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