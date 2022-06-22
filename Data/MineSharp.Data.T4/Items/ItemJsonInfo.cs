﻿using Newtonsoft.Json;

namespace MineSharp.Data.Items {
    public class ItemJsonInfo {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("stackSize")]
        public int StackSize { get; set; }

        [JsonProperty("maxDurability")]
        public int MaxDurability { get; set; }

        [JsonProperty("enchantCategories")]
        public string[] EnchantCategories { get; set; }

        [JsonProperty("repairWith")]
        public string[] RepairWith { get; set; }
    }
}
