import type { ContentData } from '../../../../../Interfaces/Frontend/DataFetching';
import type { Property } from '../../../../../Interfaces/Frontend/IGeneralInterfaces';

export interface ITabBlock extends ContentData {
    title: Property
    tabOneText: Property;
    tabOneDescription: Property;
    tabTwoText: Property;
    tabTwoDescription: Property;
    tabThreeText: Property;
    tabThreeDescription: Property;
}