using RD.Extensions.Enums.Attributes;
using static RD.TMDB.Domain.Configurations.EnumConstant;

namespace RD.TMDB.Domain.Enums;

/// <summary>
/// Language codes.
/// </summary>
public enum Iso639_1
{
    /// <summary>
    /// Default value, when no value for the language is existing.
    /// </summary>
    Undefined = 0,

    /// <summary>
    /// Language value for Aragonese.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Aragonesisch")]
    [StringValue("an")]
    Aragonese,

    /// <summary>
    /// Language value for Akan.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Akan")]
    [StringValue("ak")]
    Akan,

    /// <summary>
    /// Language value for Cree.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Cree")]
    [StringValue("cr")]
    Cree,

    /// <summary>
    /// Language value for Azerbaijani.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Aserbaidschanisch")]
    [StringValue("az")]
    Azerbaijani,

    /// <summary>
    /// Language value for Czech.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Tschechisch")]
    [StringValue("cs")]
    Czech,

    /// <summary>
    /// Language value for Afar.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Afar")]
    [StringValue("aa")]
    Afar,

    /// <summary>
    /// Language value for Breton.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Bretonisch")]
    [StringValue("br")]
    Breton,

    /// <summary>
    /// Language value for Afrikaans.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Afrikaans")]
    [StringValue("af")]
    Afrikaans,

    /// <summary>
    /// Language value for Tibetan.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Tibetisch")]
    [StringValue("bo")]
    Tibetan,

    /// <summary>
    /// Language value for Chechen.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Tschetschenisch")]
    [StringValue("ce")]
    Chechen,

    /// <summary>
    /// Language value for Cornish.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Kornisch")]
    [StringValue("kw")]
    Cornish,

    /// <summary>
    /// Language value for Faroese.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Färöisch")]
    [StringValue("fo")]
    Faroese,

    /// <summary>
    /// Language value for Latin.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Latein")]
    [StringValue("la")]
    Latin,

    /// <summary>
    /// Language value for Ndonga.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Ndonga")]
    [StringValue("ng")]
    Ndonga,

    /// <summary>
    /// Language value for Sardinian.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Sardisch")]
    [StringValue("sc")]
    Sardinian,

    /// <summary>
    /// Language value for Tigrinya.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Tigrinya")]
    [StringValue("ti")]
    Tigrinya,

    /// <summary>
    /// Language value for Tswana.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Setswana")]
    [StringValue("tn")]
    Tswana,

    /// <summary>
    /// Language value for Turkish.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Türkisch")]
    [StringValue("tr")]
    Turkish,

    /// <summary>
    /// Language value for Punjabi.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Panjabi")]
    [StringValue("pa")]
    Punjabi,

    /// <summary>
    /// Language value for Estonian.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Estnisch")]
    [StringValue("et")]
    Estonian,

    /// <summary>
    /// Language value for French.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Französisch")]
    [StringValue("fr")]
    French,

    /// <summary>
    /// Language value for Hausa.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Hausa")]
    [StringValue("ha")]
    Hausa,

    /// <summary>
    /// Language value for Icelandic.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Isländisch")]
    [StringValue("is")]
    Icelandic,

    /// <summary>
    /// Language value for Limburgish.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Limburgisch")]
    [StringValue("li")]
    Limburgish,

    /// <summary>
    /// Language value for Lingala.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Lingála")]
    [StringValue("ln")]
    Lingala,

    /// <summary>
    /// Language value for Swati.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Siswati")]
    [StringValue("ss")]
    Swati,

    /// <summary>
    /// Language value for Abkhazian.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Abchasisch")]
    [StringValue("ab")]
    Abkhazian,

    /// <summary>
    /// Language value for Serbo_Croatian.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Serbokroatisch")]
    [StringValue("sh")]
    Serbo_Croatian,

    /// <summary>
    /// Language value for Basque.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Baskisch")]
    [StringValue("eu")]
    Basque,

    /// <summary>
    /// Language value for Frisian.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Westfriesisch")]
    [StringValue("fy")]
    Frisian,

    /// <summary>
    /// Language value for Japanese.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Japanisch")]
    [StringValue("ja")]
    Japanese,

    /// <summary>
    /// Language value for Ojibwa.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Ojibwe")]
    [StringValue("oj")]
    Ojibwa,

    /// <summary>
    /// Language value for Oriya.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Oriya")]
    [StringValue("or")]
    Oriya,

    /// <summary>
    /// Language value for Pali.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Pali")]
    [StringValue("pi")]
    Pali,

    /// <summary>
    /// Language value for Sundanese.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Sundanesisch")]
    [StringValue("su")]
    Sundanese,

    /// <summary>
    /// Language value for Thai.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Thai")]
    [StringValue("th")]
    Thai,

    /// <summary>
    /// Language value for Igbo.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Igbo")]
    [StringValue("ig")]
    Igbo,

    /// <summary>
    /// Language value for Indonesian.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Indonesisch")]
    [StringValue("id")]
    Indonesian,

    /// <summary>
    /// Language value for Kazakh.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Kasachisch")]
    [StringValue("kk")]
    Kazakh,

    /// <summary>
    /// Language value for Kikuyu.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Kikuyu")]
    [StringValue("ki")]
    Kikuyu,

    /// <summary>
    /// Language value for Uighur.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Uigurisch")]
    [StringValue("ug")]
    Uighur,

    /// <summary>
    /// Language value for Venda.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Tshivenda")]
    [StringValue("ve")]
    Venda,

    /// <summary>
    /// Language value for Kinyarwanda.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Kinyarwanda")]
    [StringValue("rw")]
    Kinyarwanda,

    /// <summary>
    /// Language value for Maori.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Maori")]
    [StringValue("mi")]
    Maori,

    /// <summary>
    /// Language value for Navajo.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Navajo")]
    [StringValue("nv")]
    Navajo,

    /// <summary>
    /// Language value for Hindi.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Hindi")]
    [StringValue("hi")]
    Hindi,

    /// <summary>
    /// Language value for Portuguese.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Portugiesisch")]
    [StringValue("pt")]
    Portuguese,

    /// <summary>
    /// Language value for Sango.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Sango")]
    [StringValue("sg")]
    Sango,

    /// <summary>
    /// Language value for Slovak.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Slowakisch")]
    [StringValue("sk")]
    Slovak,

    /// <summary>
    /// Language value for Serbian.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Serbisch")]
    [StringValue("sr")]
    Serbian,

    /// <summary>
    /// Language value for Tahitian.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Tahitianisch")]
    [StringValue("ty")]
    Tahitian,

    /// <summary>
    /// Language value for Xhosa.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Xhosa")]
    [StringValue("xh")]
    Xhosa,

    /// <summary>
    /// Language value for Arabic.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Arabisch")]
    [StringValue("ar")]
    Arabic,

    /// <summary>
    /// Language value for Corsican.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Korsisch")]
    [StringValue("co")]
    Corsican,

    /// <summary>
    /// Language value for Bislama.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Bislama")]
    [StringValue("bi")]
    Bislama,

    /// <summary>
    /// Language value for Esperanto.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Esperanto")]
    [StringValue("eo")]
    Esperanto,

    /// <summary>
    /// Language value for Herero.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Otjiherero")]
    [StringValue("hz")]
    Herero,

    /// <summary>
    /// Language value for Finnish.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Finnisch")]
    [StringValue("fi")]
    Finnish,

    /// <summary>
    /// Language value for Inuktitut.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Inuktitut")]
    [StringValue("iu")]
    Inuktitut,

    /// <summary>
    /// Language value for Latvian.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Lettisch")]
    [StringValue("lv")]
    Latvian,

    /// <summary>
    /// Language value for Italian.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Italienisch")]
    [StringValue("it")]
    Italian,

    /// <summary>
    /// Language value for Dutch.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Niederländisch")]
    [StringValue("nl")]
    Dutch,

    /// <summary>
    /// Language value for Kannada.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Kannada")]
    [StringValue("kn")]
    Kannada,

    /// <summary>
    /// Language value for Sanskrit.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Sanskrit")]
    [StringValue("sa")]
    Sanskrit,

    /// <summary>
    /// Language value for Albanian.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Albanisch")]
    [StringValue("sq")]
    Albanian,

    /// <summary>
    /// Language value for Tagalog.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Tagalog")]
    [StringValue("tl")]
    Tagalog,

    /// <summary>
    /// Language value for Letzeburgesch.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Luxemburgisch")]
    [StringValue("lb")]
    Letzeburgesch,

    /// <summary>
    /// Language value for Tsonga.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Xitsonga")]
    [StringValue("ts")]
    Tsonga,

    /// <summary>
    /// Language value for Malayalam.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Malayalam")]
    [StringValue("ml")]
    Malayalam,

    /// <summary>
    /// Language value for Volapük.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Volapük")]
    [StringValue("vo")]
    Volapük,

    /// <summary>
    /// Language value for Zulu.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Zulu")]
    [StringValue("zu")]
    Zulu,

    /// <summary>
    /// Language value for Ossetian.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Ossetisch")]
    [StringValue("os")]
    Ossetian,

    /// <summary>
    /// Language value for Samoan.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Samoanisch")]
    [StringValue("sm")]
    Samoan,

    /// <summary>
    /// Language value for Zhuang.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Zhuang")]
    [StringValue("za")]
    Zhuang,

    /// <summary>
    /// Language value for Bengali_Bangla.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Bengalisch")]
    [StringValue("bn")]
    Bengali_Bangla,

    /// <summary>
    /// Language value for Slavic.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Kirchenslawisch")]
    [StringValue("cu")]
    Slavic,

    /// <summary>
    /// Language value for Irish.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Irisch")]
    [StringValue("ga")]
    Irish,

    /// <summary>
    /// Language value for Manx.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Manx")]
    [StringValue("gv")]
    Manx,

    /// <summary>
    /// Language value for Hungarian.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Ungarisch")]
    [StringValue("hu")]
    Hungarian,

    /// <summary>
    /// Language value for Javanese.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Javanisch")]
    [StringValue("jv")]
    Javanese,

    /// <summary>
    /// Language value for Kanuri.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Kanuri")]
    [StringValue("kr")]
    Kanuri,

    /// <summary>
    /// Language value for Khmer.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Khmer")]
    [StringValue("km")]
    Khmer,

    /// <summary>
    /// Language value for Kirghiz.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Kirgisisch")]
    [StringValue("ky")]
    Kirghiz,

    /// <summary>
    /// Language value for Nauru.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Nauruisch")]
    [StringValue("na")]
    Nauru,

    /// <summary>
    /// Language value for South_Ndebele.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Süd-Ndebele")]
    [StringValue("nr")]
    South_Ndebele,

    /// <summary>
    /// Language value for Occitan.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Okzitanisch")]
    [StringValue("oc")]
    Occitan,

    /// <summary>
    /// Language value for Romanian.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Rumänisch")]
    [StringValue("ro")]
    Romanian,

    /// <summary>
    /// Language value for Russian.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Russisch")]
    [StringValue("ru")]
    Russian,

    /// <summary>
    /// Language value for Armenian.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Armenisch")]
    [StringValue("hy")]
    Armenian,

    /// <summary>
    /// Language value for Chamorro.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Chamorro")]
    [StringValue("ch")]
    Chamorro,

    /// <summary>
    /// Language value for Bashkir.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Baschkirisch")]
    [StringValue("ba")]
    Bashkir,

    /// <summary>
    /// Language value for Galician.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Galicisch")]
    [StringValue("gl")]
    Galician,

    /// <summary>
    /// Language value for Ido.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Ido")]
    [StringValue("io")]
    Ido,

    /// <summary>
    /// Language value for Luba_Katanga.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Kiluba")]
    [StringValue("lu")]
    Luba_Katanga,

    /// <summary>
    /// Language value for Marshallese.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Marshallesisch")]
    [StringValue("mh")]
    Marshallese,

    /// <summary>
    /// Language value for Malagasy.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Malagasy")]
    [StringValue("mg")]
    Malagasy,

    /// <summary>
    /// Language value for Moldavian.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Rumänisch")]
    [StringValue("mo")]
    Moldavian,

    /// <summary>
    /// Language value for Mongolian.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Mongolisch")]
    [StringValue("mn")]
    Mongolian,

    /// <summary>
    /// Language value for North_Ndebele.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Nord-Ndebele")]
    [StringValue("nd")]
    North_Ndebele,

    /// <summary>
    /// Language value for Norwegian.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Norwegisch")]
    [StringValue("no")]
    Norwegian,

    /// <summary>
    /// Language value for Polish.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Polnisch")]
    [StringValue("pl")]
    Polish,

    /// <summary>
    /// Language value for Swahili.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Swahili")]
    [StringValue("sw")]
    Swahili,

    /// <summary>
    /// Language value for Tajik.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Tadschikisch")]
    [StringValue("tg")]
    Tajik,

    /// <summary>
    /// Language value for Tonga.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Tongaisch")]
    [StringValue("to")]
    Tonga,

    /// <summary>
    /// Language value for Walloon.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Wallonisch")]
    [StringValue("wa")]
    Walloon,

    /// <summary>
    /// Language value for Yiddish.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Jiddisch")]
    [StringValue("yi")]
    Yiddish,

    /// <summary>
    /// Language value for English.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Englisch")]
    [StringValue("en")]
    English,

    /// <summary>
    /// Language value for Assamese.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Assamesisch")]
    [StringValue("as")]
    Assamese,

    /// <summary>
    /// Language value for Gaelic.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Schottisch-gälisch")]
    [StringValue("gd")]
    Gaelic,

    /// <summary>
    /// Language value for Kalaallisut.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Grönländisch")]
    [StringValue("kl")]
    Kalaallisut,

    /// <summary>
    /// Language value for Burmese.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Birmanisch")]
    [StringValue("my")]
    Burmese,

    /// <summary>
    /// Language value for Quechua.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Quechua")]
    [StringValue("qu")]
    Quechua,

    /// <summary>
    /// Language value for Shona.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Shona")]
    [StringValue("sn")]
    Shona,

    /// <summary>
    /// Language value for Ukrainian.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Ukrainisch")]
    [StringValue("uk")]
    Ukrainian,

    /// <summary>
    /// Language value for Persian.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Persisch")]
    [StringValue("fa")]
    Persian,

    /// <summary>
    /// Language value for Georgian.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Georgisch")]
    [StringValue("ka")]
    Georgian,

    /// <summary>
    /// Language value for Gujarati.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Gujarati")]
    [StringValue("gu")]
    Gujarati,

    /// <summary>
    /// Language value for Avaric.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Avarisch")]
    [StringValue("av")]
    Avaric,

    /// <summary>
    /// Language value for Avestan.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Avestisch")]
    [StringValue("ae")]
    Avestan,

    /// <summary>
    /// Language value for Guarani.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Guarani")]
    [StringValue("gn")]
    Guarani,

    /// <summary>
    /// Language value for Maltese.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Maltesisch")]
    [StringValue("mt")]
    Maltese,

    /// <summary>
    /// Language value for Nepali.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Nepali")]
    [StringValue("ne")]
    Nepali,

    /// <summary>
    /// Language value for Swedish.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Schwedisch")]
    [StringValue("sv")]
    Swedish,

    /// <summary>
    /// Language value for Tatar.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Tatarisch")]
    [StringValue("tt")]
    Tatar,

    /// <summary>
    /// Language value for Wolof.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Wolof")]
    [StringValue("wo")]
    Wolof,

    /// <summary>
    /// Language value for Chuvash.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Tschuwaschisch")]
    [StringValue("cv")]
    Chuvash,

    /// <summary>
    /// Language value for Danish.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Dänisch")]
    [StringValue("da")]
    Danish,

    /// <summary>
    /// Language value for Dzongkha.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Dzongkha")]
    [StringValue("dz")]
    Dzongkha,

    /// <summary>
    /// Language value for Chichewa.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Chichewa")]
    [StringValue("ny")]
    Chichewa,

    /// <summary>
    /// Language value for Rundi.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Kirundi")]
    [StringValue("rn")]
    Rundi,

    /// <summary>
    /// Language value for Southern_Sotho.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Sesotho")]
    [StringValue("st")]
    Southern_Sotho,

    /// <summary>
    /// Language value for Turkmen.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Turkmenisch")]
    [StringValue("tk")]
    Turkmen,

    /// <summary>
    /// Language value for Uzbek.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Usbekisch")]
    [StringValue("uz")]
    Uzbek,

    /// <summary>
    /// Language value for Vietnamese.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Vietnamesisch")]
    [StringValue("vi")]
    Vietnamese,

    /// <summary>
    /// Language value for Greek.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Griechisch")]
    [StringValue("el")]
    Greek,

    /// <summary>
    /// Language value for Catalan.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Katalanisch")]
    [StringValue("ca")]
    Catalan,

    /// <summary>
    /// Language value for Welsh.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Walisisch")]
    [StringValue("cy")]
    Welsh,

    /// <summary>
    /// Language value for German.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Deutsch")]
    [StringValue("de")]
    German,

    /// <summary>
    /// Language value for Kashmiri.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Kashmiri")]
    [StringValue("ks")]
    Kashmiri,

    /// <summary>
    /// Language value for Malay.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Malaiisch")]
    [StringValue("ms")]
    Malay,

    /// <summary>
    /// Language value for Norwegian_Bokmål.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Bokmål")]
    [StringValue("nb")]
    Norwegian_Bokmål,

    /// <summary>
    /// Language value for Romansh.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Bündnerromanisch")]
    [StringValue("rm")]
    Romansh,

    /// <summary>
    /// Language value for Sinhalese.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Singhalesisch")]
    [StringValue("si")]
    Sinhalese,

    /// <summary>
    /// Language value for Spanish.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Spanisch")]
    [StringValue("es")]
    Spanish,

    /// <summary>
    /// Language value for Telugu.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Telugu")]
    [StringValue("te")]
    Telugu,

    /// <summary>
    /// Language value for Twi.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Twi")]
    [StringValue("tw")]
    Twi,

    /// <summary>
    /// Language value for Pushto.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Paschtunisch")]
    [StringValue("ps")]
    Pushto,

    /// <summary>
    /// Language value for Bulgarian.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Bulgarisch")]
    [StringValue("bg")]
    Bulgarian,

    /// <summary>
    /// Language value for Macedonian.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Mazedonisch")]
    [StringValue("mk")]
    Macedonian,

    /// <summary>
    /// Language value for Inupiaq.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Inupiaq")]
    [StringValue("ik")]
    Inupiaq,

    /// <summary>
    /// Language value for Korean.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Koreanisch")]
    [StringValue("ko")]
    Korean,

    /// <summary>
    /// Language value for Lithuanian.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Litauisch")]
    [StringValue("lt")]
    Lithuanian,

    /// <summary>
    /// Language value for Oromo.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Oromo")]
    [StringValue("om")]
    Oromo,

    /// <summary>
    /// Language value for Northern_Sami.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Nordsamisch")]
    [StringValue("se")]
    Northern_Sami,

    /// <summary>
    /// Language value for Somali.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Somali")]
    [StringValue("so")]
    Somali,

    /// <summary>
    /// Language value for Tamil.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Tamil")]
    [StringValue("ta")]
    Tamil,

    /// <summary>
    /// Language value for Urdu.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Urdu")]
    [StringValue("ur")]
    Urdu,

    /// <summary>
    /// Language value for Amharic.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Amharisch")]
    [StringValue("am")]
    Amharic,

    /// <summary>
    /// Language value for Bosnian.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Bosnisch")]
    [StringValue("bs")]
    Bosnian,

    /// <summary>
    /// Language value for Divehi.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Dhivehi")]
    [StringValue("dv")]
    Divehi,

    /// <summary>
    /// Language value for Aymara.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Aymara")]
    [StringValue("ay")]
    Aymara,

    /// <summary>
    /// Language value for Bambara.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Bambara")]
    [StringValue("bm")]
    Bambara,

    /// <summary>
    /// Language value for Sichuan_Yi.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Yi")]
    [StringValue("ii")]
    Sichuan_Yi,

    /// <summary>
    /// Language value for Interlingue.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Interlingue")]
    [StringValue("ie")]
    Interlingue,

    /// <summary>
    /// Language value for Komi.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Komi")]
    [StringValue("kv")]
    Komi,

    /// <summary>
    /// Language value for Kurdish.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Kurdisch")]
    [StringValue("ku")]
    Kurdish,

    /// <summary>
    /// Language value for Norwegian_Nynorsk.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Nynorsk")]
    [StringValue("nn")]
    Norwegian_Nynorsk,

    /// <summary>
    /// Language value for Chinese_Mandarin.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Chinesisch")]
    [StringValue("zh")]
    Chinese_Mandarin,

    /// <summary>
    /// Language value for Hebrew.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Hebräisch")]
    [StringValue("he")]
    Hebrew,

    /// <summary>
    /// Language value for Ewe.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Ewe")]
    [StringValue("ee")]
    Ewe,

    /// <summary>
    /// Language value for Fijian.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Fidschi")]
    [StringValue("fj")]
    Fijian,

    /// <summary>
    /// Language value for Fulah.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Fulfulde")]
    [StringValue("ff")]
    Fulah,

    /// <summary>
    /// Language value for Haitian.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Haitianisch")]
    [StringValue("ht")]
    Haitian,

    /// <summary>
    /// Language value for Croatian.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Kroatisch")]
    [StringValue("hr")]
    Croatian,

    /// <summary>
    /// Language value for Interlingua.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Interlingua")]
    [StringValue("ia")]
    Interlingua,

    /// <summary>
    /// Language value for Kuanyama.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "oshiKwanyama")]
    [StringValue("kj")]
    Kuanyama,

    /// <summary>
    /// Language value for Lao.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Laotisch")]
    [StringValue("lo")]
    Lao,

    /// <summary>
    /// Language value for Ganda.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Luganda")]
    [StringValue("lg")]
    Ganda,

    /// <summary>
    /// Language value for Marathi.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Marathi")]
    [StringValue("mr")]
    Marathi,

    /// <summary>
    /// Language value for Sindhi.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Sindhi")]
    [StringValue("sd")]
    Sindhi,

    /// <summary>
    /// Language value for Belarusian.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Belarussisch")]
    [StringValue("be")]
    Belarusian,

    /// <summary>
    /// Language value for Hiri_Motu.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Hiri Motu")]
    [StringValue("ho")]
    Hiri_Motu,

    /// <summary>
    /// Language value for Kongo.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Kikongo")]
    [StringValue("kg")]
    Kongo,

    /// <summary>
    /// Language value for Slovenian.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Slowenisch")]
    [StringValue("sl")]
    Slovenian,

    /// <summary>
    /// Language value for Yoruba.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Yoruba")]
    [StringValue("yo")]
    Yoruba,

    /// <summary>
    /// Language value for No_Language.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "")]
    [StringValue("xx")]
    No_Language,

    /// <summary>
    /// Language value for Cantonese.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Kantonesisch")]
    [StringValue("cn")]
    Cantonese
}