using RD.Extensions.Enums.Attributes;
using static RD.TMDB.Domain.Configurations.EnumConstant;

namespace RD.TMDB.Domain.Enums;

/// <summary>
/// Country and language codes together.
/// </summary>
public enum CountryAndLanguage
{
    /// <summary>
    /// Default value, when no value for country and language is existing.
    /// </summary>
    Undefined = 0,

    [KeyValuePair(CountryKey, Iso3166_1.Bahrain)]
    [KeyValuePair(LanguageKey, Iso639_1.Arabic)]
    Bahrain_Arabic,

    [KeyValuePair(CountryKey, Iso3166_1.Egypt)]
    [KeyValuePair(LanguageKey, Iso639_1.Arabic)]
    Egypt_Arabic,

    [KeyValuePair(CountryKey, Iso3166_1.Iraq)]
    [KeyValuePair(LanguageKey, Iso639_1.Arabic)]
    Iraq_Arabic,

    [KeyValuePair(CountryKey, Iso3166_1.Jordan)]
    [KeyValuePair(LanguageKey, Iso639_1.Arabic)]
    Jordan_Arabic,

    [KeyValuePair(CountryKey, Iso3166_1.Libya)]
    [KeyValuePair(LanguageKey, Iso639_1.Arabic)]
    Libya_Arabic,

    [KeyValuePair(CountryKey, Iso3166_1.Morocco)]
    [KeyValuePair(LanguageKey, Iso639_1.Arabic)]
    Morocco_Arabic,

    [KeyValuePair(CountryKey, Iso3166_1.Qatar)]
    [KeyValuePair(LanguageKey, Iso639_1.Arabic)]
    Qatar_Arabic,

    [KeyValuePair(CountryKey, Iso3166_1.Chad)]
    [KeyValuePair(LanguageKey, Iso639_1.Arabic)]
    Chad_Arabic,

    [KeyValuePair(CountryKey, Iso3166_1.Yemen)]
    [KeyValuePair(LanguageKey, Iso639_1.Arabic)]
    Yemen_Arabic,

    [KeyValuePair(CountryKey, Iso3166_1.France)]
    [KeyValuePair(LanguageKey, Iso639_1.Breton)]
    France_Breton,

    [KeyValuePair(CountryKey, Iso3166_1.Andorra)]
    [KeyValuePair(LanguageKey, Iso639_1.Catalan)]
    Andorra_Catalan,

    [KeyValuePair(CountryKey, Iso3166_1.Cyprus)]
    [KeyValuePair(LanguageKey, Iso639_1.Greek)]
    Cyprus_Greek,

    [KeyValuePair(CountryKey, Iso3166_1.Antigua_And_Barbuda)]
    [KeyValuePair(LanguageKey, Iso639_1.English)]
    Antigua_And_Barbuda_English,

    [KeyValuePair(CountryKey, Iso3166_1.Barbados)]
    [KeyValuePair(LanguageKey, Iso639_1.English)]
    Barbados_English,

    [KeyValuePair(CountryKey, Iso3166_1.Belize)]
    [KeyValuePair(LanguageKey, Iso639_1.English)]
    Belize_English,

    [KeyValuePair(CountryKey, Iso3166_1.Cameroon)]
    [KeyValuePair(LanguageKey, Iso639_1.English)]
    Cameroon_English,

    [KeyValuePair(CountryKey, Iso3166_1.Bailiwick_Of_Guernsey)]
    [KeyValuePair(LanguageKey, Iso639_1.English)]
    Bailiwick_Of_Guernsey_English,

    [KeyValuePair(CountryKey, Iso3166_1.Ghana)]
    [KeyValuePair(LanguageKey, Iso639_1.English)]
    Ghana_English,

    [KeyValuePair(CountryKey, Iso3166_1.Gibraltar)]
    [KeyValuePair(LanguageKey, Iso639_1.English)]
    Gibraltar_English,

    [KeyValuePair(CountryKey, Iso3166_1.Guyana)]
    [KeyValuePair(LanguageKey, Iso639_1.English)]
    Guyana_English,

    [KeyValuePair(CountryKey, Iso3166_1.Jamaica)]
    [KeyValuePair(LanguageKey, Iso639_1.English)]
    Jamaica_English,

    [KeyValuePair(CountryKey, Iso3166_1.Kenya)]
    [KeyValuePair(LanguageKey, Iso639_1.English)]
    Kenya_English,

    [KeyValuePair(CountryKey, Iso3166_1.St_Lucia)]
    [KeyValuePair(LanguageKey, Iso639_1.English)]
    St_Lucia_English,

    [KeyValuePair(CountryKey, Iso3166_1.Malawi)]
    [KeyValuePair(LanguageKey, Iso639_1.English)]
    Malawi_English,

    [KeyValuePair(CountryKey, Iso3166_1.Papua_New_Guinea)]
    [KeyValuePair(LanguageKey, Iso639_1.English)]
    Papua_New_Guinea_English,

    [KeyValuePair(CountryKey, Iso3166_1.Turks_And_Caicos_Islands)]
    [KeyValuePair(LanguageKey, Iso639_1.English)]
    Turks_And_Caicos_Islands_English,

    [KeyValuePair(CountryKey, Iso3166_1.Zambia)]
    [KeyValuePair(LanguageKey, Iso639_1.English)]
    Zambia_English,

    [KeyValuePair(CountryKey, Iso3166_1.Zimbabwe)]
    [KeyValuePair(LanguageKey, Iso639_1.English)]
    Zimbabwe_English,

    [KeyValuePair(CountryKey, Iso3166_1.Argentina)]
    [KeyValuePair(LanguageKey, Iso639_1.Spanish)]
    Argentina_Spanish,

    [KeyValuePair(CountryKey, Iso3166_1.Chile)]
    [KeyValuePair(LanguageKey, Iso639_1.Spanish)]
    Chile_Spanish,

    [KeyValuePair(CountryKey, Iso3166_1.Dominican_Republic)]
    [KeyValuePair(LanguageKey, Iso639_1.Spanish)]
    Dominican_Republic_Spanish,

    [KeyValuePair(CountryKey, Iso3166_1.Ecuador)]
    [KeyValuePair(LanguageKey, Iso639_1.Spanish)]
    Ecuador_Spanish,

    [KeyValuePair(CountryKey, Iso3166_1.Equatorial_Guinea)]
    [KeyValuePair(LanguageKey, Iso639_1.Spanish)]
    Equatorial_Guinea_Spanish,

    [KeyValuePair(CountryKey, Iso3166_1.Guatemala)]
    [KeyValuePair(LanguageKey, Iso639_1.Spanish)]
    Guatemala_Spanish,

    [KeyValuePair(CountryKey, Iso3166_1.Honduras)]
    [KeyValuePair(LanguageKey, Iso639_1.Spanish)]
    Honduras_Spanish,

    [KeyValuePair(CountryKey, Iso3166_1.Nicaragua)]
    [KeyValuePair(LanguageKey, Iso639_1.Spanish)]
    Nicaragua_Spanish,

    [KeyValuePair(CountryKey, Iso3166_1.Panama)]
    [KeyValuePair(LanguageKey, Iso639_1.Spanish)]
    Panama_Spanish,

    [KeyValuePair(CountryKey, Iso3166_1.Peru)]
    [KeyValuePair(LanguageKey, Iso639_1.Spanish)]
    Peru_Spanish,

    [KeyValuePair(CountryKey, Iso3166_1.Paraguay)]
    [KeyValuePair(LanguageKey, Iso639_1.Spanish)]
    Paraguay_Spanish,

    [KeyValuePair(CountryKey, Iso3166_1.El_Salvador)]
    [KeyValuePair(LanguageKey, Iso639_1.Spanish)]
    El_Salvador_Spanish,

    [KeyValuePair(CountryKey, Iso3166_1.Uruguay)]
    [KeyValuePair(LanguageKey, Iso639_1.Spanish)]
    Uruguay_Spanish,

    [KeyValuePair(CountryKey, Iso3166_1.Burkina_Faso)]
    [KeyValuePair(LanguageKey, Iso639_1.French)]
    Burkina_Faso_French,

    [KeyValuePair(CountryKey, Iso3166_1.Democratic_Republic_Congo)]
    [KeyValuePair(LanguageKey, Iso639_1.French)]
    Democratic_Republic_Congo_French,

    [KeyValuePair(CountryKey, Iso3166_1.Cote_D_Ivoire)]
    [KeyValuePair(LanguageKey, Iso639_1.French)]
    Cote_D_Ivoire_French,

    [KeyValuePair(CountryKey, Iso3166_1.French_Guiana)]
    [KeyValuePair(LanguageKey, Iso639_1.French)]
    French_Guiana_French,

    [KeyValuePair(CountryKey, Iso3166_1.Guadaloupe)]
    [KeyValuePair(LanguageKey, Iso639_1.French)]
    Guadaloupe_French,

    [KeyValuePair(CountryKey, Iso3166_1.Monaco)]
    [KeyValuePair(LanguageKey, Iso639_1.French)]
    Monaco_French,

    [KeyValuePair(CountryKey, Iso3166_1.Mali)]
    [KeyValuePair(LanguageKey, Iso639_1.French)]
    Mali_French,

    [KeyValuePair(CountryKey, Iso3166_1.Mauritius)]
    [KeyValuePair(LanguageKey, Iso639_1.French)]
    Mauritius_French,

    [KeyValuePair(CountryKey, Iso3166_1.French_Polynesia)]
    [KeyValuePair(LanguageKey, Iso639_1.French)]
    French_Polynesia_French,

    [KeyValuePair(CountryKey, Iso3166_1.Ireland)]
    [KeyValuePair(LanguageKey, Iso639_1.Irish)]
    Ireland_Irish,

    [KeyValuePair(CountryKey, Iso3166_1.United_Kingdom)]
    [KeyValuePair(LanguageKey, Iso639_1.Gaelic)]
    United_Kingdom_Gaelic,

    [KeyValuePair(CountryKey, Iso3166_1.Croatia)]
    [KeyValuePair(LanguageKey, Iso639_1.Croatian)]
    Croatia_Croatian,

    [KeyValuePair(CountryKey, Iso3166_1.Vatican_City)]
    [KeyValuePair(LanguageKey, Iso639_1.Italian)]
    Vatican_City_Italian,

    [KeyValuePair(CountryKey, Iso3166_1.Kyrgyz_Republic)]
    [KeyValuePair(LanguageKey, Iso639_1.Kirghiz)]
    Kyrgyz_Republic_Kirghiz,

    [KeyValuePair(CountryKey, Iso3166_1.India)]
    [KeyValuePair(LanguageKey, Iso639_1.Marathi)]
    India_Marathi,

    [KeyValuePair(CountryKey, Iso3166_1.Belgium)]
    [KeyValuePair(LanguageKey, Iso639_1.Dutch)]
    Belgium_Dutch,

    [KeyValuePair(CountryKey, Iso3166_1.India)]
    [KeyValuePair(LanguageKey, Iso639_1.Punjabi)]
    India_Punjabi,

    [KeyValuePair(CountryKey, Iso3166_1.Angola)]
    [KeyValuePair(LanguageKey, Iso639_1.Portuguese)]
    Angola_Portuguese,

    [KeyValuePair(CountryKey, Iso3166_1.Mozambique)]
    [KeyValuePair(LanguageKey, Iso639_1.Portuguese)]
    Mozambique_Portuguese,

    [KeyValuePair(CountryKey, Iso3166_1.Moldova)]
    [KeyValuePair(LanguageKey, Iso639_1.Romanian)]
    Moldova_Romanian,

    [KeyValuePair(CountryKey, Iso3166_1.Kosovo)]
    [KeyValuePair(LanguageKey, Iso639_1.Albanian)]
    Kosovo_Albanian,

    [KeyValuePair(CountryKey, Iso3166_1.Montenegro)]
    [KeyValuePair(LanguageKey, Iso639_1.Serbian)]
    Montenegro_Serbian,

    [KeyValuePair(CountryKey, Iso3166_1.Tanzania)]
    [KeyValuePair(LanguageKey, Iso639_1.Swahili)]
    Tanzania_Swahili,

    [KeyValuePair(CountryKey, Iso3166_1.Pakistan)]
    [KeyValuePair(LanguageKey, Iso639_1.Urdu)]
    Pakistan_Urdu,

    /// <summary>
    /// Country and language value for united kingdom - welsh.
    /// </summary>
    [KeyValuePair(CountryKey, Iso3166_1.United_Kingdom)]
    [KeyValuePair(LanguageKey, Iso639_1.Welsh)]
    UnitedKingdom_Welsh,

    /// <summary>
    /// Country and language value for china - cantonese.
    /// </summary>
    [KeyValuePair(CountryKey, Iso3166_1.China)]
    [KeyValuePair(LanguageKey, Iso639_1.Cantonese)]
    China_Cantonese,

    /// <summary>
    /// Country and language value for south africa - afrikaans.
    /// </summary>
    [KeyValuePair(CountryKey, Iso3166_1.South_Africa)]
    [KeyValuePair(LanguageKey, Iso639_1.Afrikaans)]
    SouthAfrica_Afrikaans,

    /// <summary>
    /// Country and language value for united arab emirates - arabic.
    /// </summary>
    [KeyValuePair(CountryKey, Iso3166_1.United_Arab_Emirates)]
    [KeyValuePair(LanguageKey, Iso639_1.Arabic)]
    UnitedArabEmirates_Arabic,

    /// <summary>
    /// Country and language value for saudi arabia - arabic.
    /// </summary>
    [KeyValuePair(CountryKey, Iso3166_1.Saudi_Arabia)]
    [KeyValuePair(LanguageKey, Iso639_1.Arabic)]
    SaudiArabia_Arabic,

    /// <summary>
    /// Country and language value for belarus - belarusian.
    /// </summary>
    [KeyValuePair(CountryKey, Iso3166_1.Belarus)]
    [KeyValuePair(LanguageKey, Iso639_1.Belarusian)]
    Belarus_Belarusian,

    /// <summary>
    /// Country and language value for bulgaria - bulgarian.
    /// </summary>
    [KeyValuePair(CountryKey, Iso3166_1.Bulgaria)]
    [KeyValuePair(LanguageKey, Iso639_1.Bulgarian)]
    Bulgaria_Bulgarian,

    /// <summary>
    /// Country and language value for bangladesh - bengali bangla.
    /// </summary>
    [KeyValuePair(CountryKey, Iso3166_1.Bangladesh)]
    [KeyValuePair(LanguageKey, Iso639_1.Bengali_Bangla)]
    Bangladesh_Bengali_Bangla,

    /// <summary>
    /// Country and language value for spain - catalan.
    /// </summary>
    [KeyValuePair(CountryKey, Iso3166_1.Spain)]
    [KeyValuePair(LanguageKey, Iso639_1.Catalan)]
    Spain_Catalan,

    /// <summary>
    /// Country and language value for guam - chamorro.
    /// </summary>
    [KeyValuePair(CountryKey, Iso3166_1.Guam)]
    [KeyValuePair(LanguageKey, Iso639_1.Chamorro)]
    Guam_Chamorro,

    /// <summary>
    /// Country and language value for czechia - czech.
    /// </summary>
    [KeyValuePair(CountryKey, Iso3166_1.Czechia)]
    [KeyValuePair(LanguageKey, Iso639_1.Czech)]
    Czechia_Czech,

    /// <summary>
    /// Country and language value for denmark - danish.
    /// </summary>
    [KeyValuePair(CountryKey, Iso3166_1.Denmark)]
    [KeyValuePair(LanguageKey, Iso639_1.Danish)]
    Denmark_Danish,

    /// <summary>
    /// Country and language value for austria - german.
    /// </summary>
    [KeyValuePair(CountryKey, Iso3166_1.Austria)]
    [KeyValuePair(LanguageKey, Iso639_1.German)]
    Austria_German,

    /// <summary>
    /// Country and language value for switzerland - german.
    /// </summary>
    [KeyValuePair(CountryKey, Iso3166_1.Switzerland)]
    [KeyValuePair(LanguageKey, Iso639_1.German)]
    Switzerland_German,

    /// <summary>
    /// Country and language value for germany - german.
    /// </summary>
    [KeyValuePair(CountryKey, Iso3166_1.Germany)]
    [KeyValuePair(LanguageKey, Iso639_1.German)]
    Germany_German,

    /// <summary>
    /// Country and language value for greece - greek.
    /// </summary>
    [KeyValuePair(CountryKey, Iso3166_1.Greece)]
    [KeyValuePair(LanguageKey, Iso639_1.Greek)]
    Greece_Greek,

    /// <summary>
    /// Country and language value for australia - english.
    /// </summary>
    [KeyValuePair(CountryKey, Iso3166_1.Australia)]
    [KeyValuePair(LanguageKey, Iso639_1.English)]
    Australia_English,

    /// <summary>
    /// Country and language value for canada - english.
    /// </summary>
    [KeyValuePair(CountryKey, Iso3166_1.Canada)]
    [KeyValuePair(LanguageKey, Iso639_1.English)]
    Canada_English,

    /// <summary>
    /// Country and language value for united kingdom - english.
    /// </summary>
    [KeyValuePair(CountryKey, Iso3166_1.United_Kingdom)]
    [KeyValuePair(LanguageKey, Iso639_1.English)]
    UnitedKingdom_English,

    /// <summary>
    /// Country and language value for ireland - english.
    /// </summary>
    [KeyValuePair(CountryKey, Iso3166_1.Ireland)]
    [KeyValuePair(LanguageKey, Iso639_1.English)]
    Ireland_English,

    /// <summary>
    /// Country and language value for new zealand - english.
    /// </summary>
    [KeyValuePair(CountryKey, Iso3166_1.New_Zealand)]
    [KeyValuePair(LanguageKey, Iso639_1.English)]
    NewZealand_English,

    /// <summary>
    /// Country and language value for united states - english.
    /// </summary>
    [KeyValuePair(CountryKey, Iso3166_1.United_States)]
    [KeyValuePair(LanguageKey, Iso639_1.English)]
    UnitedStates_English,

    /// <summary>
    /// Country and language value for spain - spanish.
    /// </summary>
    [KeyValuePair(CountryKey, Iso3166_1.Spain)]
    [KeyValuePair(LanguageKey, Iso639_1.Spanish)]
    Spain_Spanish,

    /// <summary>
    /// Country and language value for mexico - spanish.
    /// </summary>
    [KeyValuePair(CountryKey, Iso3166_1.Mexico)]
    [KeyValuePair(LanguageKey, Iso639_1.Spanish)]
    Mexico_Spanish,

    /// <summary>
    /// Country and language value for estonia - estonian.
    /// </summary>
    [KeyValuePair(CountryKey, Iso3166_1.Estonia)]
    [KeyValuePair(LanguageKey, Iso639_1.Estonian)]
    Estonia_Estonian,

    /// <summary>
    /// Country and language value for spain - basque.
    /// </summary>
    [KeyValuePair(CountryKey, Iso3166_1.Spain)]
    [KeyValuePair(LanguageKey, Iso639_1.Basque)]
    Spain_Basque,

    /// <summary>
    /// Country and language value for iran - persian.
    /// </summary>
    [KeyValuePair(CountryKey, Iso3166_1.Iran)]
    [KeyValuePair(LanguageKey, Iso639_1.Persian)]
    Iran_Persian,

    /// <summary>
    /// Country and language value for finland - finnish.
    /// </summary>
    [KeyValuePair(CountryKey, Iso3166_1.Finland)]
    [KeyValuePair(LanguageKey, Iso639_1.Finnish)]
    Finland_Finnish,

    /// <summary>
    /// Country and language value for canada - french.
    /// </summary>
    [KeyValuePair(CountryKey, Iso3166_1.Canada)]
    [KeyValuePair(LanguageKey, Iso639_1.French)]
    Canada_French,

    /// <summary>
    /// Country and language value for france - french.
    /// </summary>
    [KeyValuePair(CountryKey, Iso3166_1.France)]
    [KeyValuePair(LanguageKey, Iso639_1.French)]
    France_French,

    /// <summary>
    /// Country and language value for spain - galician.
    /// </summary>
    [KeyValuePair(CountryKey, Iso3166_1.Spain)]
    [KeyValuePair(LanguageKey, Iso639_1.Galician)]
    Spain_Galician,

    /// <summary>
    /// Country and language value for israel - hebrew.
    /// </summary>
    [KeyValuePair(CountryKey, Iso3166_1.Israel)]
    [KeyValuePair(LanguageKey, Iso639_1.Hebrew)]
    Israel_Hebrew,

    /// <summary>
    /// Country and language value for india - hindi.
    /// </summary>
    [KeyValuePair(CountryKey, Iso3166_1.India)]
    [KeyValuePair(LanguageKey, Iso639_1.Hindi)]
    India_Hindi,

    /// <summary>
    /// Country and language value for hungary - hungarian.
    /// </summary>
    [KeyValuePair(CountryKey, Iso3166_1.Hungary)]
    [KeyValuePair(LanguageKey, Iso639_1.Hungarian)]
    Hungary_Hungarian,

    /// <summary>
    /// Country and language value for indonesia - indonesian.
    /// </summary>
    [KeyValuePair(CountryKey, Iso3166_1.Indonesia)]
    [KeyValuePair(LanguageKey, Iso639_1.Indonesian)]
    Indonesia_Indonesian,

    /// <summary>
    /// Country and language value for italy - italian.
    /// </summary>
    [KeyValuePair(CountryKey, Iso3166_1.Italy)]
    [KeyValuePair(LanguageKey, Iso639_1.Italian)]
    Italy_Italian,

    /// <summary>
    /// Country and language value for japan - japanese.
    /// </summary>
    [KeyValuePair(CountryKey, Iso3166_1.Japan)]
    [KeyValuePair(LanguageKey, Iso639_1.Japanese)]
    Japan_Japanese,

    /// <summary>
    /// Country and language value for georgia - georgian.
    /// </summary>
    [KeyValuePair(CountryKey, Iso3166_1.Georgia)]
    [KeyValuePair(LanguageKey, Iso639_1.Georgian)]
    Georgia_Georgian,

    /// <summary>
    /// Country and language value for kazakhstan - kazakh.
    /// </summary>
    [KeyValuePair(CountryKey, Iso3166_1.Kazakhstan)]
    [KeyValuePair(LanguageKey, Iso639_1.Kazakh)]
    Kazakhstan_Kazakh,

    /// <summary>
    /// Country and language value for india - kannada.
    /// </summary>
    [KeyValuePair(CountryKey, Iso3166_1.India)]
    [KeyValuePair(LanguageKey, Iso639_1.Kannada)]
    India_Kannada,

    /// <summary>
    /// Country and language value for south korea - korean.
    /// </summary>
    [KeyValuePair(CountryKey, Iso3166_1.South_Korea)]
    [KeyValuePair(LanguageKey, Iso639_1.Korean)]
    SouthKorea_Korean,

    /// <summary>
    /// Country and language value for lithuania - lithuanian.
    /// </summary>
    [KeyValuePair(CountryKey, Iso3166_1.Lithuania)]
    [KeyValuePair(LanguageKey, Iso639_1.Lithuanian)]
    Lithuania_Lithuanian,

    /// <summary>
    /// Country and language value for latvia - latvian.
    /// </summary>
    [KeyValuePair(CountryKey, Iso3166_1.Latvia)]
    [KeyValuePair(LanguageKey, Iso639_1.Latvian)]
    Latvia_Latvian,

    /// <summary>
    /// Country and language value for india - malayalam.
    /// </summary>
    [KeyValuePair(CountryKey, Iso3166_1.India)]
    [KeyValuePair(LanguageKey, Iso639_1.Malayalam)]
    India_Malayalam,

    /// <summary>
    /// Country and language value for malaysia - malay.
    /// </summary>
    [KeyValuePair(CountryKey, Iso3166_1.Malaysia)]
    [KeyValuePair(LanguageKey, Iso639_1.Malay)]
    Malaysia_Malay,

    /// <summary>
    /// Country and language value for singapore - malay.
    /// </summary>
    [KeyValuePair(CountryKey, Iso3166_1.Singapore)]
    [KeyValuePair(LanguageKey, Iso639_1.Malay)]
    Singapore_Malay,

    /// <summary>
    /// Country and language value for norway - norwegian.
    /// </summary>
    [KeyValuePair(CountryKey, Iso3166_1.Norway)]
    [KeyValuePair(LanguageKey, Iso639_1.Norwegian_Bokmål)]
    Norway_NorwegianBokmål,

    /// <summary>
    /// Country and language value for netherlands - dutch.
    /// </summary>
    [KeyValuePair(CountryKey, Iso3166_1.Netherlands)]
    [KeyValuePair(LanguageKey, Iso639_1.Dutch)]
    Netherlands_Dutch,

    /// <summary>
    /// Country and language value for norway - norwegian.
    /// </summary>
    [KeyValuePair(CountryKey, Iso3166_1.Norway)]
    [KeyValuePair(LanguageKey, Iso639_1.Norwegian)]
    Norway_Norwegian,

    /// <summary>
    /// Country and language value for poland - polish.
    /// </summary>
    [KeyValuePair(CountryKey, Iso3166_1.Poland)]
    [KeyValuePair(LanguageKey, Iso639_1.Polish)]
    Poland_Polish,

    /// <summary>
    /// Country and language value for brazil - portuguese.
    /// </summary>
    [KeyValuePair(CountryKey, Iso3166_1.Brazil)]
    [KeyValuePair(LanguageKey, Iso639_1.Portuguese)]
    Brazil_Portuguese,

    /// <summary>
    /// Country and language value for portugal - portuguese.
    /// </summary>
    [KeyValuePair(CountryKey, Iso3166_1.Portugal)]
    [KeyValuePair(LanguageKey, Iso639_1.Portuguese)]
    Portugal_Portuguese,

    /// <summary>
    /// Country and language value for romania - romanian.
    /// </summary>
    [KeyValuePair(CountryKey, Iso3166_1.Romania)]
    [KeyValuePair(LanguageKey, Iso639_1.Romanian)]
    Romania_Romanian,

    /// <summary>
    /// Country and language value for russia - russian.
    /// </summary>
    [KeyValuePair(CountryKey, Iso3166_1.Russia)]
    [KeyValuePair(LanguageKey, Iso639_1.Russian)]
    Russia_Russian,

    /// <summary>
    /// Country and language value for sir lanka - sinhalese.
    /// </summary>
    [KeyValuePair(CountryKey, Iso3166_1.Sri_Lanka)]
    [KeyValuePair(LanguageKey, Iso639_1.Sinhalese)]
    SriLanka_Sinhalese,

    /// <summary>
    /// Country and language value for slovakia - slovak.
    /// </summary>
    [KeyValuePair(CountryKey, Iso3166_1.Slovakia)]
    [KeyValuePair(LanguageKey, Iso639_1.Slovak)]
    Slovakia_Slovak,

    /// <summary>
    /// Country and language value for slovenia - slovenian.
    /// </summary>
    [KeyValuePair(CountryKey, Iso3166_1.Slovenia)]
    [KeyValuePair(LanguageKey, Iso639_1.Slovenian)]
    Slovenia_Slovenian,

    /// <summary>
    /// Country and language value for albania - albanian.
    /// </summary>
    [KeyValuePair(CountryKey, Iso3166_1.Albania)]
    [KeyValuePair(LanguageKey, Iso639_1.Albanian)]
    Albania_Albanian,

    /// <summary>
    /// Country and language value for serbia - serbian.
    /// </summary>
    [KeyValuePair(CountryKey, Iso3166_1.Serbia)]
    [KeyValuePair(LanguageKey, Iso639_1.Serbian)]
    Serbia_Serbian,

    /// <summary>
    /// Country and language value for sweden - swedish.
    /// </summary>
    [KeyValuePair(CountryKey, Iso3166_1.Sweden)]
    [KeyValuePair(LanguageKey, Iso639_1.Swedish)]
    Sweden_Swedish,

    /// <summary>
    /// Country and language value for india - tamil.
    /// </summary>
    [KeyValuePair(CountryKey, Iso3166_1.India)]
    [KeyValuePair(LanguageKey, Iso639_1.Tamil)]
    India_Tamil,

    /// <summary>
    /// Country and language value for india - telugu.
    /// </summary>
    [KeyValuePair(CountryKey, Iso3166_1.India)]
    [KeyValuePair(LanguageKey, Iso639_1.Telugu)]
    India_Telugu,

    /// <summary>
    /// Country and language value for thailand - thai.
    /// </summary>
    [KeyValuePair(CountryKey, Iso3166_1.Thailand)]
    [KeyValuePair(LanguageKey, Iso639_1.Thai)]
    Thailand_Thai,

    /// <summary>
    /// Country and language value for philippines - tagalog.
    /// </summary>
    [KeyValuePair(CountryKey, Iso3166_1.Philippines)]
    [KeyValuePair(LanguageKey, Iso639_1.Tagalog)]
    Philippines_Tagalog,

    /// <summary>
    /// Country and language value for turkey - turkish.
    /// </summary>
    [KeyValuePair(CountryKey, Iso3166_1.Turkey)]
    [KeyValuePair(LanguageKey, Iso639_1.Turkish)]
    Turkey_Turkish,

    /// <summary>
    /// Country and language value for ukraine - ukrainian.
    /// </summary>
    [KeyValuePair(CountryKey, Iso3166_1.Ukraine)]
    [KeyValuePair(LanguageKey, Iso639_1.Ukrainian)]
    Ukraine_Ukrainian,

    /// <summary>
    /// Country and language value for vietnam - vietnamese.
    /// </summary>
    [KeyValuePair(CountryKey, Iso3166_1.Vietnam)]
    [KeyValuePair(LanguageKey, Iso639_1.Vietnamese)]
    Vietnam_Vietnamese,

    /// <summary>
    /// Country and language value for china - chinese mandarin.
    /// </summary>
    [KeyValuePair(CountryKey, Iso3166_1.China)]
    [KeyValuePair(LanguageKey, Iso639_1.Chinese_Mandarin)]
    Cina_Chinese_Mandarin,

    /// <summary>
    /// Country and language value for hong kong - chinese mandarin.
    /// </summary>
    [KeyValuePair(CountryKey, Iso3166_1.Hong_Kong)]
    [KeyValuePair(LanguageKey, Iso639_1.Chinese_Mandarin)]
    HongKong_Chinese_Mandarin,

    /// <summary>
    /// Country and language value for singapore - chinese mandarin.
    /// </summary>
    [KeyValuePair(CountryKey, Iso3166_1.Singapore)]
    [KeyValuePair(LanguageKey, Iso639_1.Chinese_Mandarin)]
    Singapore_Chinese_Mandarin,

    /// <summary>
    /// Country and language value for taiwan - chinese mandarin.
    /// </summary>
    [KeyValuePair(CountryKey, Iso3166_1.Taiwan)]
    [KeyValuePair(LanguageKey, Iso639_1.Chinese_Mandarin)]
    Taiwan_Chinese_Mandarin,

    /// <summary>
    /// Country and language value for south africa - zulu.
    /// </summary>
    [KeyValuePair(CountryKey, Iso3166_1.South_Africa)]
    [KeyValuePair(LanguageKey, Iso639_1.Zulu)]
    SouthAfrica_Zulu
}