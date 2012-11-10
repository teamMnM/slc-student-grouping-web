using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace SlcClient.Enum
{
    [DataContract]
    public enum LanguageItemType
    {
        [EnumMember(Value = "Spanish")]    
        Spanish,
        [EnumMember(Value = "Vietnamese")]
        Vietnamese,
        [EnumMember(Value = "Laotian (Lao)")]
        LaotianLao,
        [EnumMember(Value = "Cambodian (Khmer)")]
        CambodianKhmer,
        [EnumMember(Value = "Korean")]
        Korean,
        [EnumMember(Value = "Japanese")]
        Japanese,
        [EnumMember(Value = "French")]
        French,
        [EnumMember(Value = "German")]
        German,
        [EnumMember(Value = "English")]
        English,
        [EnumMember(Value = "Other languages")]
        OtherLanguages,
        [EnumMember(Value = "Afrikaans (Taal)")]
        AfrikaansTaal,
        [EnumMember(Value = "Akan (Fante, Asante)")]
        AkanFanteAsante,
        [EnumMember(Value = "Albanian, Gheg (Kossovo/Macedonia)")]
        AlbanianGhegKossovoMacedonia,
        [EnumMember(Value = "Albanian, Tosk (Albania)")]
        AlbanianToskAlbania,
        [EnumMember(Value = "Algonquin")]
        Algonquin,
        [EnumMember(Value = "Amharic")]
        Amharic,
        [EnumMember(Value = "Apache")]
        Apache,
        [EnumMember(Value = "Arabic")]
        Arabic,
        [EnumMember(Value = "Armenian")]
        Armenian,
        [EnumMember(Value = "Assyrian (Syriac, Aramaic)")]
        AssyrianSyriacAramaic,
        [EnumMember(Value = "Balinese")]
        Balinese,
        [EnumMember(Value = "Bengali")]
        Bengali,
        [EnumMember(Value = "Bosnian")]
        Bosnian,
        [EnumMember(Value = "Bulgarian")]
        Bulgarian,
        [EnumMember(Value = "Burmese")]
        Burmese,
        [EnumMember(Value = "Cantonese (Chinese)")]
        CantoneseChinese,
        [EnumMember(Value = "Cebuano (Visayan)")]
        CebuanoVisayan,
        [EnumMember(Value = "Chamorro")]
        Chamorro,
        [EnumMember(Value = "Chaochow/Teochiu (Chinese)")]
        ChaochowTeochiuChinese,
        [EnumMember(Value = "Cherokee")]
        Cherokee,
        [EnumMember(Value = "Chippewa/Ojibawa/Ottawa")]
        ChippewaOjibawaOttawa,
        [EnumMember(Value = "Choctaw")]
        Choctaw,
        [EnumMember(Value = "Comanche")]
        Comanche,
        [EnumMember(Value = "Coushatta")]
        Coushatta,
        [EnumMember(Value = "Creek")]
        Creek,
        [EnumMember(Value = "Croatian")]
        Croatian,
        [EnumMember(Value = "Crow")]
        Crow,
        [EnumMember(Value = "Czech")]
        Czech,
        [EnumMember(Value = "Danish")]
        Danish,
        [EnumMember(Value = "Dard")]
        Dard,
        [EnumMember(Value = "Dutch/Flemish")]
        DutchFlemish,
        [EnumMember(Value = "Efik")]
        Efik,
        [EnumMember(Value = "Eskimo")]
        Eskimo,
        [EnumMember(Value = "Estonian")]
        Estonian,
        [EnumMember(Value = "Ethiopic")]
        Ethiopic,
        [EnumMember(Value = "Ewe")]
        Ewe,
        [EnumMember(Value = "Farsi (Persian)")]
        FarsiPersian,
        [EnumMember(Value = "Finnish")]
        Finnish,
        [EnumMember(Value = "Fukien/Hokkien (Chinese)")]
        FukienHokkienChinese,
        [EnumMember(Value = "Gaelic (Irish)")]
        GaelicIrish,
        [EnumMember(Value = "Gaelic (Scottish)")]
        GaelicScottish,
        [EnumMember(Value = "Greek")]
        Greek,
        [EnumMember(Value = "Gujarati")]
        Gujarati,
        [EnumMember(Value = "Guyanese")]
        Guyanese,
        [EnumMember(Value = "Hainanese (Chinese)")]
        HainaneseChinese,
        [EnumMember(Value = "Haitian-Creole")]
        HaitianCreole,
        [EnumMember(Value = "Hakka (Chinese)")]
        HakkaChinese,
        [EnumMember(Value = "Hausa")]
        Hausa,
        [EnumMember(Value = "Hebrew")]
        Hebrew,
        [EnumMember(Value = "Hindi")]
        Hindi,
        [EnumMember(Value = "Hmong")]
        Hmong,
        [EnumMember(Value = "Hopi")]
        Hopi,
        [EnumMember(Value = "Hungarian")]
        Hungarian,
        [EnumMember(Value = "Ibo/Igbo")]
        IboIgbo,
        [EnumMember(Value = "Icelandic")]
        Icelandic,
        [EnumMember(Value = "Ilonggo (Hiligaynon)")]
        IlonggoHiligaynon,
        [EnumMember(Value = "Indonesian")]
        Indonesian,
        [EnumMember(Value = "Italian")]
        Italian,
        [EnumMember(Value = "Kache (Kaje, Jju)")]
        KacheKajeJju,
        [EnumMember(Value = "Kannada (Kanarese)")]
        KannadaKanarese,
        [EnumMember(Value = "Kanuri")]
        Kanuri,
        [EnumMember(Value = "Kashmiri")]
        Kashmiri,
        [EnumMember(Value = "Kickapoo")]
        Kickapoo,
        [EnumMember(Value = "WoKonkanirk")]
        Konkani,
        [EnumMember(Value = "Kpelle")]
        Kpelle,
        [EnumMember(Value = "Krio")]
        Krio,
        [EnumMember(Value = "Kurdish")]
        Kurdish,
        [EnumMember(Value = "Kwa")]
        Kwa,
        [EnumMember(Value = "Latvian")]
        Latvian,
        [EnumMember(Value = "Lingala")]
        Lingala,
        [EnumMember(Value = "Lithuanian")]
        Lithuanian,
        [EnumMember(Value = "Luganda")]
        Luganda,
        [EnumMember(Value = "Lunda")]
        Lunda,
        [EnumMember(Value = "Luyia (Luhya)")]
        LuyiaLuhya,
        [EnumMember(Value = "Macedonian")]
        Macedonian,
        [EnumMember(Value = "Malay")]
        Malay,
        [EnumMember(Value = "Malayalam")]
        Malayalam,
        [EnumMember(Value = "Maltese")]
        Maltese,
        [EnumMember(Value = "Mandarin (Chinese)")]
        MandarinChinese,
        [EnumMember(Value = "Mande")]
        Mande,
        [EnumMember(Value = "Marathi")]
        Marathi,
        [EnumMember(Value = "Menominee")]
        Menominee,
        [EnumMember(Value = "Mien (Yao)")]
        MienYao,
        [EnumMember(Value = "Navajo")]
        Navajo,
        [EnumMember(Value = "Nepali")]
        Nepali,
        [EnumMember(Value = "Norwegian")]
        Norwegian,
        [EnumMember(Value = "Okinawan")]
        Okinawan,
        [EnumMember(Value = "Oneida")]
        Oneida,
        [EnumMember(Value = "Oriya")]
        Oriya,
        [EnumMember(Value = "Orri (Oring)")]
        OrriOring,
        [EnumMember(Value = "Pampangan")]
        Pampangan,
        [EnumMember(Value = "Panjabi (Punjabi)")]
        PanjabiPunjabi,
        [EnumMember(Value = "Pashto (Pushto)")]
        PashtoPushto,
        [EnumMember(Value = "Pilipino (Tagalog)")]
        PilipinoTagalog,
        [EnumMember(Value = "Pima")]
        Pima,
        [EnumMember(Value = "Polish")]
        Polish,
        [EnumMember(Value = "Portuguese")]
        Portuguese,
        [EnumMember(Value = "Pueblo")]
        Pueblo,
        [EnumMember(Value = "Romanian")]
        Romanian,
        [EnumMember(Value = "Romany (Gypsy)")]
        RomanyGypsy,
        [EnumMember(Value = "Russian")]
        Russian,
        [EnumMember(Value = "Samoan")]
        Samoan,
        [EnumMember(Value = "Serbian")]
        Serbian,
        [EnumMember(Value = "Shanghai (Chinese)")]
        ShanghaiChinese,
        [EnumMember(Value = "Shona")]
        Shona,
        [EnumMember(Value = "Sikkimese")]
        Sikkimese,
        [EnumMember(Value = "Sindhi")]
        Sindhi,
        [EnumMember(Value = "Sinhalese (Sri Lanka)")]
        SinhaleseSriLanka,
        [EnumMember(Value = "Sioux (Dakota)")]
        SiouxDakota,
        [EnumMember(Value = "Slavic")]
        Slavic,
        [EnumMember(Value = "Slovenian (Slovene)")]
        SlovenianSlovene,
        [EnumMember(Value = "Somali")]
        Somali,
        [EnumMember(Value = "Sotho")]
        Sotho,
        [EnumMember(Value = "Swahili")]
        Swahili,
        [EnumMember(Value = "Swedish")]
        Swedish,
        [EnumMember(Value = "Taiwanese/Formosan/Min Nan (Chinese)")]
        TaiwaneseFormosanMinNanChinese,
        [EnumMember(Value = "Tamil")]
        Tamil,
        [EnumMember(Value = "Telugu (Telegu)")]
        TeluguTelegu,
        [EnumMember(Value = "Thai")]
        Thai,
        [EnumMember(Value = "Tibetan")]
        Tibetan,
        [EnumMember(Value = "Tigrinya")]
        Tigrinya,
        [EnumMember(Value = "Tiwa")]
        Tiwa,
        [EnumMember(Value = "Tuluau")]
        Tuluau,
        [EnumMember(Value = "Turkish")]
        Turkish,
        [EnumMember(Value = "Ukrainian")]
        Ukrainian,
        [EnumMember(Value = "Urdu")]
        Urdu,
        [EnumMember(Value = "Welsh")]
        Welsh,
        [EnumMember(Value = "Winnebago")]
        Winnebago,
        [EnumMember(Value = "Yiddish")]
        Yiddish,
        [EnumMember(Value = "Yombe")]
        Yombe,
        [EnumMember(Value = "Yoruba")]
        Yoruba
    }
}