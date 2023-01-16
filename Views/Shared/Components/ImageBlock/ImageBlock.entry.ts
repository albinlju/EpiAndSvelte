/// <reference types="svelte" />
import ImageBlock from "./ImageBlock.svelte";
const imageContainer = document.getElementById("imageBlock");

export default new ImageBlock({
    target: imageContainer ? imageContainer : new ShadowRoot,
    props: {
        imageId: imageContainer?.dataset.id as string
    }
});
    