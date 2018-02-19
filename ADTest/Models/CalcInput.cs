using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace ADTest.Models
{
    public class CalcInput
    {
        [JsonProperty(PropertyName = "a")]
        public int a { get; set; }


        [JsonProperty(PropertyName = "b")]
        public int b { get; set; }
    }
}