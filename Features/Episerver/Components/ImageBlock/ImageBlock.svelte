<script lang="ts">
  import { onMount } from "svelte";
  import type { ImagBlock } from "../../../../Interfaces/Frontend/Blocks";
  import { __epiDataService } from "../../../../Services/Frontend/EpiDataService";

  let data: any;
  export let imageId: string;

  const getData = async () => {
    const response = await __epiDataService.getContentById<ImagBlock>(imageId);
    data = response.url;
  };

  onMount(getData);
</script>

<img src={data} alt="Bild" />

<style lang="scss">
</style>
