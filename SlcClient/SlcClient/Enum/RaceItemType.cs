using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace SlcClient.Enum
{
    [DataContract]
    public enum RaceItemType
    {
        [EnumMember(Value = "American Indian - Alaskan Native")]
        AmericanIndianAlaskanNative,
        [EnumMember(Value = "Asian")]
        Asian,
        [EnumMember(Value = "Black - African American")]
        BlackAfricanAmerican,
        [EnumMember(Value = "Native Hawaiian - Pacific Islander")]
        NativeHawaiianPacificIslander,
        [EnumMember(Value = "White")]
        White
    }
}