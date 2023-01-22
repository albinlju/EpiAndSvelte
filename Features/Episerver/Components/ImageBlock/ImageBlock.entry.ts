/// <reference types="svelte" />
import ImageBlock from "../../../Svelte/Components/EpiserverBlocks/ImageBlock/ImageBlock.svelte";
const imageContainer = document.getElementById("imageBlock");

export default new ImageBlock({
    target: imageContainer ? imageContainer : new ShadowRoot,
    props: {
        blockId: imageContainer?.dataset.id as string
    }
});
    