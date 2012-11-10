using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace SlcClient.Enum
{
    [DataContract]
    public enum OldEthnicityType
    {
        [EnumMember(Value = "American Indian Or Alaskan Native")]
        AmericanIndianOrAlaskanNative,
        [EnumMember(Value = "Asian Or Pacific Islander")]
        AsianOrPacificIslander,
        [EnumMember(Value = "Black, Not Of Hispanic Origin")]
        BlackNotOfHispanicOrigin,
        [EnumMember(Value = "Hispanic")]
        Hispanic,
        [EnumMember(Value = "White, Not Of Hispanic Origin")]
        WhiteNotOfHispanicOrigin
    }
}