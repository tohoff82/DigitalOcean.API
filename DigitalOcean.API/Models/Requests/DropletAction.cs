﻿using Newtonsoft.Json;

namespace DigitalOcean.API.Models.Requests {
    public class DropletAction {
        /// <summary>
        /// Type of action
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Size slug
        /// </summary>
        /// <remarks>
        /// Used by:
        ///     Resize Droplet action
        /// </remarks>
        [JsonProperty("size")]
        public string Size { get; set; }

        /// <summary>
        /// Image ID or Slug
        /// </summary>
        /// <remarks>
        /// Used by:
        ///     Restore Droplet action
        ///     Rebuild Droplet action
        /// </remarks>
        [JsonProperty("image")]
        public object Image { get; set; }

        /// <summary>
        /// New name
        /// </summary>
        /// <remarks>
        /// Used by:
        ///     Rename Droplet action
        /// </remarks>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Kernel id
        /// </summary>
        /// <remarks>
        /// Used by:
        ///     Change Kernel Droplet action
        /// </remarks>
        [JsonProperty("kernel")]
        public long? KernelId { get; set; }

        /// <summary>
        /// Whether to increase disk size.
        /// </summary>
        /// <remarks>
        /// Used by:
        ///     Resize Droplet action
        /// </remarks>
        [JsonProperty("disk")]
        public bool? Disk { get; set; }
    }
}
