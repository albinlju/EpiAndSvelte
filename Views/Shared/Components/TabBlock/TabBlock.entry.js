/// <reference types="svelte" />
import TabBlock from "./TabBlock.svelte";
const tabBlockContainer = document.getElementById("tabBlock");
export default new TabBlock({
    target: (tabBlockContainer === null || tabBlockContainer === void 0 ? void 0 : tabBlockContainer.parentElement) ? tabBlockContainer.parentElement : new ShadowRoot,
    props: {
        tabBlockId: tabBlockContainer === null || tabBlockContainer === void 0 ? void 0 : tabBlockContainer.dataset.id
    },
    intro: true
});
tabBlockContainer === null || tabBlockContainer === void 0 ? void 0 : tabBlockContainer.remove();
//# sourceMappingURL=TabBlock.entry.js.map