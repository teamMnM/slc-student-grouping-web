using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace SlcClient.Enum
{
    [DataContract]
    public enum DisabilityType
    {
        [EnumMember(Value = "Autistic/Autism")]
        AutisticAutism,
        [EnumMember(Value = "Deaf-Blindness")]
        DeafBlindness,
        [EnumMember(Value = "Deafness")]
        Deafness,
        [EnumMember(Value = "Developmental Delay")]
        DevelopmentalDelay,
        [EnumMember(Value = "Emotional Disturbance")]
        EmotionalDisturbance,
        [EnumMember(Value = "Hearing/Auditory Impairment")]
        HearingAuditoryImpairment,
        [EnumMember(Value = "Infants and Toddlers with Disabilities")]
        InfantsAndToddlersWithDisabilities,
        [EnumMember(Value = "Mental Retardation")]
        MentalRetardation,
        [EnumMember(Value = "Multiple Disabilities")]
        MultipleDisabilities,
        [EnumMember(Value = "Orthopedic Impairment")]
        OrthopedicImpairment,
        [EnumMember(Value = "Other Health Impairment")]
        OtherHealthImpairment,
        [EnumMember(Value = "Speech or Language Impairment")]
        SpeechOrLanguageImpairment,
        [EnumMember(Value = "Specific Learning Disability")]
        SpecificLearningDisability,
        [EnumMember(Value = "Traumatic Brain Delay")]
        TraumaticBrainDelay,
        [EnumMember(Value = "Visual Impairment")]
        VisualImpairment
    }
}