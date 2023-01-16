/// <reference types="svelte" />
import ImageBlock from "./ImageBlock.svelte";
const imageContainer = document.getElementById("imageBlock");
export default new ImageBlock({
    target: imageContainer ? imageContainer : new ShadowRoot,
    props: {
        imageId: imageContainer === null || imageContainer === void 0 ? void 0 : imageContainer.dataset.id
    }
});
//# sourceMappingURL=ImageBlock.entry.js.map