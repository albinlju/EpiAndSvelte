import type { ContentData } from './DataFetching';

export type Property = {
    value: string;
    propertyDataType: string;
}

export interface ImagBlock extends ContentData {
    url: string;
}

