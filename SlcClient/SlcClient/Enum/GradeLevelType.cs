using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace SlcClient.Enum
{
    [DataContract]
    public enum GradeLevelType
    {
        [EnumMember(Value = "Adult Education")]
        AdultEducation,
        [EnumMember(Value = "Early Education")]
        EarlyEducation,
        [EnumMember(Value = "Eighth grade")]
        EighthGrade,
        [EnumMember(Value = "Eleventh grade")]
        EleventhGrade,
        [EnumMember(Value = "Fifth grade")]
        FifthGrade,
        [EnumMember(Value = "First grade")]
        FirstGrade,
        [EnumMember(Value = "Fourth grade")]
        FourthGrade,
        [EnumMember(Value = "Grade 13")]
        Grade13,
        [EnumMember(Value = "Infant/toddler")]
        InfantToddler,
        [EnumMember(Value = "Kindergarten")]
        Kindergarten,
        [EnumMember(Value = "Ninth grade")]
        NinthGrade,
        [EnumMember(Value = "Other")]
        Other,
        [EnumMember(Value = "Postsecondary")]
        Postsecondary,
        [EnumMember(Value = "Preschool/Prekindergarten")]
        PreschoolPrekindergarten,
        [EnumMember(Value = "Second grade")]
        SecondGrade,
        [EnumMember(Value = "Seventh grade")]
        SeventhGrade,
        [EnumMember(Value = "Sixth grade")]
        SixthGrade,
        [EnumMember(Value = "Tenth grade")]
        TenthGrade,
        [EnumMember(Value = "Home/Personal")]
        ThirdGrade,
        [EnumMember(Value = "Transitional Kindergarten")]
        TransitionalKindergarten,
        [EnumMember(Value = "Twelfth grade")]
        TwelfthGrade,
        [EnumMember(Value = "Ungraded")]
        Ungraded,
        [EnumMember(Value = "Not Available")]
        NotAvailable
    }
}