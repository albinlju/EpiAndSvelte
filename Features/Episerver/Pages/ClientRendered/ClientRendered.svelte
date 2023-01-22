<script lang="ts">
  import { onMount } from "svelte";
  import { __epiDataService } from "../../../../Services/Frontend/EpiDataService";
  import BlockRenderer from "../../../Svelte/Components/BlockRenderer.svelte";
  import type { ClientRenderedPage } from "./ClientRenderedTypes";

  let response: ClientRenderedPage;

  const getPageData = async () => {
    if (pageId != "") {
      response = await __epiDataService.getContentById<ClientRenderedPage>(
        pageId,
        true
      );
    }
  };

  export let pageId: string;

  onMount(getPageData);
</script>

{#if response}
  <h1>{response.title.value}</h1>
  <p>{response.intro.value}</p>
  <BlockRenderer blocks={response.blocks.expandedValue} />
{/if}

<style lang="scss">
</style>
