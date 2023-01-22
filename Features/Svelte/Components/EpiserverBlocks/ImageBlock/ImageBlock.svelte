<script lang="ts">
  import { onMount } from "svelte";
  import type { IImageBlock } from "./IImageBlock";
  import { __epiDataService } from "../../../../../Services/Frontend/EpiDataService";

  export let blockId: string;
  export let blockData: IImageBlock | null = null;

  const getData = async () => {
    const response = await __epiDataService.getContentById<IImageBlock>(
      blockId
    );
    blockData = response;
  };

  if (blockId) {
    onMount(getData);
  }
</script>

{#if blockData}
  <img src={blockData.image.value.url} alt="Bild" />
{/if}

<style lang="scss">
</style>
