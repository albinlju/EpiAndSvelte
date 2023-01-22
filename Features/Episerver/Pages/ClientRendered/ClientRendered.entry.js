var _a;
/// <reference types="svelte" />
import ClientRendered from "./ClientRendered.svelte";
const app = document.getElementById("root");
(_a = app === null || app === void 0 ? void 0 : app.querySelector("#clientRenderedSpinner")) === null || _a === void 0 ? void 0 : _a.remove();
export default new ClientRendered({
    target: app ? app : new ShadowRoot,
    props: {
        pageId: (app === null || app === void 0 ? void 0 : app.dataset.id) ? app.dataset.id : ""
    }
});
//# sourceMappingURL=ClientRendered.entry.js.map