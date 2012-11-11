﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using System.ComponentModel;

namespace SlcClient.Enum
{
    [DataContract]
    public enum GradeLevelType
    {
        [EnumMember(Value = "Adult Education")]
        [Description("Adult Education")]
        AdultEducation,
        [EnumMember(Value = "Early Education")]
        [Description("Early Education")]
        EarlyEducation,
        [EnumMember(Value = "Eighth grade")]
        [Description("Eighth grade")]
        EighthGrade,
        [EnumMember(Value = "Eleventh grade")]
        [Description("Eleventh grade")]
        EleventhGrade,
        [EnumMember(Value = "Fifth grade")]
        [Description("Fifth grade")]
        FifthGrade,
        [EnumMember(Value = "First grade")]
        [Description("First grade")]
        FirstGrade,
        [EnumMember(Value = "Fourth grade")]
        [Description("Fourth grade")]
        FourthGrade,
        [EnumMember(Value = "Grade 13")]
        [Description("Grade 13")]
        Grade13,
        [EnumMember(Value = "Infant/toddler")]
        [Description("Infant/toddler")]
        InfantToddler,
        [EnumMember(Value = "Kindergarten")]
        [Description("Kindergarten")]
        Kindergarten,
        [EnumMember(Value = "Ninth grade")]
        [Description("Ninth grade")]
        NinthGrade,
        [EnumMember(Value = "Other")]
        [Description("Other")]
        Other,
        [EnumMember(Value = "Postsecondary")]
        [Description("Postsecondary")]
        Postsecondary,
        [EnumMember(Value = "Preschool/Prekindergarten")]
        [Description("Preschool/Prekindergarten")]
        PreschoolPrekindergarten,
        [EnumMember(Value = "Second grade")]
        [Description("Second grade")]
        SecondGrade,
        [EnumMember(Value = "Seventh grade")]
        [Description("Seventh grade")]
        SeventhGrade,
        [EnumMember(Value = "Sixth grade")]
        [Description("Sixth grade")]
        SixthGrade,
        [EnumMember(Value = "Tenth grade")]
        [Description("Tenth grade")]
        TenthGrade,
        [EnumMember(Value = "Home/Personal")]
        [Description("Home/Personal")]
        ThirdGrade,
        [EnumMember(Value = "Transitional Kindergarten")]
        [Description("Transitional Kindergarten")]
        TransitionalKindergarten,
        [EnumMember(Value = "Twelfth grade")]
        [Description("Twelfth grade")]
        TwelfthGrade,
        [EnumMember(Value = "Ungraded")]
        [Description("Ungraded")]
        Ungraded,
        [EnumMember(Value = "Not Available")]
        [Description("Not Available")]
        NotAvailable
    }
}