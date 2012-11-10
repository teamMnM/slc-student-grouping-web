using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace SlcClient.Enum
{
    [DataContract]
    public enum SchoolFoodServicesEligibilityType
    {
        [EnumMember(Value = "Free")]
        Free,
        [EnumMember(Value = "Full price")]
        FullPrice,
        [EnumMember(Value = "Reduced price")]
        ReducedPrice,
        [EnumMember(Value = "Unknown")]
        Unknown
    }
}