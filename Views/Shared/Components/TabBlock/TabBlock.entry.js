/// <reference types="svelte" />
import TabBlock from "./TabBlock.svelte";
const tabBlockContainer = document.getElementById("tabBlock");
export default new TabBlock({
    target: tabBlockContainer ? tabBlockContainer : new ShadowRoot,
    props: {
        tabBlockId: tabBlockContainer === null || tabBlockContainer === void 0 ? void 0 : tabBlockContainer.dataset.id
    }
});
//# sourceMappingURL=TabBlock.entry.js.map