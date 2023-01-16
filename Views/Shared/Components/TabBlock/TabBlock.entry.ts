/// <reference types="svelte" />
import TabBlock from "./TabBlock.svelte";
const tabBlockContainer = document.getElementById("tabBlock");

export default new TabBlock({
    target: tabBlockContainer ? tabBlockContainer : new ShadowRoot,
    props: {
        tabBlockId: tabBlockContainer?.dataset.id as string
    }
});
    