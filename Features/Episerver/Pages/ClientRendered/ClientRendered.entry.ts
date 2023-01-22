/// <reference types="svelte" />
import ClientRendered from "./ClientRendered.svelte";
const app = document.getElementById("root");
app?.querySelector("#clientRenderedSpinner")?.remove();

export default new ClientRendered({
    target: app ? app : new ShadowRoot,
    props: {
        pageId: app?.dataset.id ? app.dataset.id : ""
    }
});
