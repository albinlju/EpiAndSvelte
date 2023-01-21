<script lang="ts">
  import { onMount } from "svelte";
  import type { TabBlock } from "./TabBlockType";
  import { __epiDataService } from "../../../../Services/Frontend/EpiDataService";
  import Spinner from "../../../../Views/Shared/SvelteComponents/Spinner.svelte";

  const getData = async () => {
    const response = await __epiDataService.GetContentById<TabBlock>(
      tabBlockId
    );
    data = response;
  };

  const changeActiveDescription = (event: Event) => {
    const target = event.target as HTMLButtonElement;
    if (!(target instanceof HTMLButtonElement)) {
      return;
    }
    activeDescription = target.dataset.id ? JSON.parse(target.dataset.id) : "";
  };

  let data: TabBlock;
  let activeDescription = 1;
  export let tabBlockId: string;

  onMount(getData);
</script>

{#if data}
  <ul
    class="grid grid-flow-col text-center text-gray-500 bg-zinc-800 rounded-lg p-1 mb-4"
  >
    <li>
      <button
        data-id="1"
        on:click={changeActiveDescription}
        class="flex justify-center w-full 
        {activeDescription == 1
          ? 'bg-zinc-600 text-gray-100'
          : ''} rounded-lg py-4 text-gray-400">{data.tabOneText.value}</button
      >
    </li>
    <li>
      <button
        data-id="2"
        on:click={changeActiveDescription}
        class="flex justify-center w-full 
        {activeDescription == 2
          ? 'bg-zinc-600 text-gray-100'
          : ''} rounded-lg text-gray-400 py-4">{data.tabTwoText.value}</button
      >
    </li>
    <li>
      <button
        data-id="3"
        on:click={changeActiveDescription}
        class="flex justify-center w-full 
        {activeDescription == 3
          ? 'bg-zinc-600 text-gray-100'
          : ''} rounded-lg text-gray-400 py-4">{data.tabTwoText.value}</button
      >
    </li>
  </ul>
  <div class="tab-content mb-10" id="tabs-tabContentFill">
    {#if activeDescription == 1}
      <div
        class="tab-pane fade {activeDescription == 1 ? 'active show' : ''}"
        id="tabs-homeFill"
        role="tabpanel"
        aria-labelledby="tabs-home-tabFill"
      >
        <div>{@html data.tabThreeDescription.value}</div>
      </div>
    {/if}

    {#if activeDescription == 2}
      <div
        class="tab-pane fade {activeDescription == 2 ? 'active show' : ''}"
        id="tabs-profileFill"
        role="tabpanel"
        aria-labelledby="tabs-profile-tabFill"
      >
        <div>{@html data.tabTwoDescription.value}</div>
      </div>
    {/if}

    {#if activeDescription == 3}
      <div
        class="tab-pane fade {activeDescription == 3 ? 'active show' : ''}"
        id="tabs-messagesFill"
        role="tabpanel"
        aria-labelledby="tabs-profile-tabFill"
      >
        {@html data.tabOneDescription.value}
      </div>
    {/if}
  </div>
{/if}

<style lang="scss">
</style>
