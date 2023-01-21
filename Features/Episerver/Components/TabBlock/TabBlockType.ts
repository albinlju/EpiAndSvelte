import type { Property } from "../../../../Interfaces/Frontend/Blocks";
import type { ContentData } from "../../../../Interfaces/Frontend/DataFetching";

export interface TabBlock extends ContentData {
    title: Property
    tabOneText: Property;
    tabOneDescription: Property;
    tabTwoText: Property;
    tabTwoDescription: Property;
    tabThreeText: Property;
    tabThreeDescription: Property;
}