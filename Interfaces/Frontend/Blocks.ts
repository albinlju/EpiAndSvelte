import type { ContentData } from './DataFetching';

type Property = {
    value: string;
    propertyDataType: string;
}

export interface ImagBlock extends ContentData {
    url: string;
}

export interface TabBlock extends ContentData {
    title: Property
    tabOneText: Property;
    tabOneDescription: Property;
    tabTwoText: Property;
    tabTwoDescription: Property;
    tabThreeText: Property;
    tabThreeDescription: Property;
}