using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DotnetYuzuncuYil.Core.DTOs
{
    public class NoContentDto
    {
        [JsonIgnore]
        public int StatusCode { get; set; }
        public List<string> Errors{ get; set; }
    }
}
