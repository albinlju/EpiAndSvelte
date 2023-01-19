export function replaceTarget (target: HTMLElement | ShadowRoot, SvelteComponent: any) {

    const component = new SvelteComponent({
        target: target.parentElement,
        anchor: target,
    });
    component.render();
    if(target instanceof HTMLElement){
        target.remove();
    }

    return component
}