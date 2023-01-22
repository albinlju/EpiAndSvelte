<script lang="ts">
  import type { IImagBlock } from "../../../../../Interfaces/Frontend/Blocks";
  export let blockData: IImagBlock;
</script>

<img alt="" src={blockData.image.value.url} />
