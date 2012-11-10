using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace SlcClient.Enum
{
    [DataContract]
    public enum Section504DisabilityItemType
    {
        [EnumMember(Value = "Attention Deficit Hyperactivity Disorder (ADHD)")]
        AttentionDeficitHyperactivityDisorderADHD,
        [EnumMember(Value = "Medical Condition")]
        MedicalCondition,
        [EnumMember(Value = "Motor Impairment")]
        MotorImpairment,
        [EnumMember(Value = "Sensory Impairment")]
        SensoryImpairment,
        [EnumMember(Value = "Other")]
        Other
    }
}