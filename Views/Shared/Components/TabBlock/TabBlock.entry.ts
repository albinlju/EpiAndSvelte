/// <reference types="svelte" />
import TabBlock from "./TabBlock.svelte";
const tabBlockContainer = document.getElementById("tabBlock");


export default new TabBlock({
    target: tabBlockContainer?.parentElement ? tabBlockContainer.parentElement : new ShadowRoot,
    props: {
        tabBlockId: tabBlockContainer?.dataset.id as string
    },
    intro: true
});
tabBlockContainer?.remove();
    