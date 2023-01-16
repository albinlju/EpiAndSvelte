<script lang="ts">
import { onMount } from "svelte";
import type { TabBlock } from "../../../../Interfaces/Frontend/Blocks";
import { __epiDataService } from "../../../../Services/Frontend/EpiDataService";

const getData = async () => {
    const response = await __epiDataService.GetContentById<TabBlock>(tabBlockId);
    data = response;
}

const changeActiveDescription = (event: Event) => {
    const target = event.target as HTMLButtonElement;
    if (!(event.target instanceof HTMLButtonElement)) {
        return;
    }
    activeDescription = event.target.dataset.id ? JSON.parse(event.target.dataset.id) : ""
}

let data: TabBlock;
let activeDescription = 1;
export let tabBlockId: string;



onMount(getData)


</script>


{#if data}
    <ul class="nav nav-tabs bg-red-500">
        <li class="nav-item">
            <button data-id={1} on:click={changeActiveDescription} class="nav-link active" aria-current="page">{data.tabOneText.value}</button>
        </li>
        <li class="nav-item">
            <button data-id={2} on:click={changeActiveDescription} class="nav-link" >{data.tabTwoText.value}</button>
        </li>
        <li class="nav-item">
            <button data-id={3} on:click={changeActiveDescription} class="nav-link">{data.tabThreeText.value}</button>
        </li>
    </ul>
    {#if activeDescription == 1}
        <div>{@html data.tabOneDescription.value}</div>
    {/if}
    
    {#if activeDescription == 2}
        <div>{@html data.tabTwoDescription.value}</div>
    {/if}
    
    {#if activeDescription == 3}
        <div>{@html data.tabThreeDescription.value}</div>
    {/if}
{/if}

<style lang="scss">

</style>