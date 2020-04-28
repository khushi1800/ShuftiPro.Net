﻿using Newtonsoft.Json;
using ShuftiPro.Enums;

namespace ShuftiPro.Base
{
    public class ShuftiProAddressInfo : ShuftiProAddressBase
    {
        [JsonProperty("selected_type")]
        public ShuftiProDocumentType[] SelectedType { get; set; }
    }
}
