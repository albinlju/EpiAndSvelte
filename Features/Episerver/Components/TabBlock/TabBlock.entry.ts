/// <reference types="svelte" />
import TabBlock from "../../../Svelte/Components/EpiserverBlocks/TabBlock/TabBlock.svelte";
const tabBlockContainer = document.getElementById("tabBlock");


export default new TabBlock({
    target: tabBlockContainer?.parentElement ? tabBlockContainer.parentElement : new ShadowRoot,
    props: {
        blockId: tabBlockContainer?.dataset.id as string
    },
    intro: true
});
tabBlockContainer?.remove();
    