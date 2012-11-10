using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace SlcClient.Enum
{
    [DataContract]
    public enum SexType
    {
        [EnumMember(Value = "Female")]
        Female,
        [EnumMember(Value = "Male")]
        Male
    }
}