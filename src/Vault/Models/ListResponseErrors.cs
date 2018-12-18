using System.Collections.Generic;
using Newtonsoft.Json;

namespace Vault.Models
{
    public class ListResponseErrors
    {
        [JsonProperty("errors")]
        public List<string> Errors { get; set; }
    }
}