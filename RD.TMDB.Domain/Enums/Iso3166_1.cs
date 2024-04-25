using RD.Extensions.Enums.Attributes;
using static RD.TMDB.Domain.Configurations.EnumConstant;

namespace RD.TMDB.Domain.Enums;

/// <summary>
/// Country codes.
/// </summary>
public enum Iso3166_1
{
    /// <summary>
    /// Default value, when no value for the country is existing.
    /// </summary>
    Undefined = 0,

    /// <summary>
    /// Country value for 
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Andorra")]
    [StringValue("AD")]
    Andorra,

    /// <summary>
    /// Country value for United_Arab_Emirates.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Vereinigte Arabische Emirate")]
    [StringValue("AE")]
    United_Arab_Emirates,

    /// <summary>
    /// Country value for Afghanistan.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Afghanistan")]
    [StringValue("AF")]
    Afghanistan,

    /// <summary>
    /// Country value for Antigua_And_Barbuda.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Antigua und Barbuda")]
    [StringValue("AG")]
    Antigua_And_Barbuda,

    /// <summary>
    /// Country value for Anguilla.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Anguilla")]
    [StringValue("AI")]
    Anguilla,

    /// <summary>
    /// Country value for Armenia.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Armenien")]
    [StringValue("AM")]
    Armenia,

    /// <summary>
    /// Country value for Netherlands_Antilles.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Niederländische Antillen")]
    [StringValue("AN")]
    Netherlands_Antilles,

    /// <summary>
    /// Country value for Angola.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Angola")]
    [StringValue("AO")]
    Angola,

    /// <summary>
    /// Country value for Antarctica.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Antarktis")]
    [StringValue("AQ")]
    Antarctica,

    /// <summary>
    /// Country value for Argentina.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Argentinien")]
    [StringValue("AR")]
    Argentina,

    /// <summary>
    /// Country value for American_Samoa.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Amerikanisch-Samoa")]
    [StringValue("AS")]
    American_Samoa,

    /// <summary>
    /// Country value for Åland.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Åland")]
    [StringValue("AX")]
    Åland,

    /// <summary>
    /// Country value for Saudi_Arabia.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Saudi-Arabien")]
    [StringValue("SA")]
    Saudi_Arabia,

    /// <summary>
    /// Country value for Belarus.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Belarus")]
    [StringValue("BY")]
    Belarus,

    /// <summary>
    /// Country value for Belize.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Belize")]
    [StringValue("BZ")]
    Belize,

    /// <summary>
    /// Country value for Bulgaria.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Bulgarien")]
    [StringValue("BG")]
    Bulgaria,

    /// <summary>
    /// Country value for Bahrain.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Bahrain")]
    [StringValue("BH")]
    Bahrain,

    /// <summary>
    /// Country value for Burundi.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Burundi")]
    [StringValue("BI")]
    Burundi,

    /// <summary>
    /// Country value for Benin.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Benin")]
    [StringValue("BJ")]
    Benin,

    /// <summary>
    /// Country value for Bangladesh.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Bangladesch")]
    [StringValue("BD")]
    Bangladesh,

    /// <summary>
    /// Country value for Bermuda.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Bermuda")]
    [StringValue("BM")]
    Bermuda,

    /// <summary>
    /// Country value for Brunei.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Brunei")]
    [StringValue("BN")]
    Brunei,

    /// <summary>
    /// Country value for Saint_Barthélemy.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Saint-Barthélemy")]
    [StringValue("BL")]
    Saint_Barthélemy,

    /// <summary>
    /// Country value for Bolivia.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Bolivien")]
    [StringValue("BO")]
    Bolivia,

    /// <summary>
    /// Country value for Bonaire.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Bonaire")]
    [StringValue("BQ")]
    Bonaire,

    /// <summary>
    /// Country value for Spain.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Spanien")]
    [StringValue("ES")]
    Spain,

    /// <summary>
    /// Country value for Curaçao.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Curaçao")]
    [StringValue("CW")]
    Curaçao,

    /// <summary>
    /// Country value for Guam.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Guam")]
    [StringValue("GU")]
    Guam,

    /// <summary>
    /// Country value for China.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Volksrepublik China")]
    [StringValue("CN")]
    China,

    /// <summary>
    /// Country value for Czechia.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Tschechien")]
    [StringValue("CZ")]
    Czechia,

    /// <summary>
    /// Country value for Denmark.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Dänemark")]
    [StringValue("DK")]
    Denmark,

    /// <summary>
    /// Country value for Austria.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Österreich")]
    [StringValue("AT")]
    Austria,

    /// <summary>
    /// Country value for Aruba.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Aruba")]
    [StringValue("AW")]
    Aruba,

    /// <summary>
    /// Country value for Azerbaijan.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Aserbaidschan")]
    [StringValue("AZ")]
    Azerbaijan,

    /// <summary>
    /// Country value for Bosnia_And_Herzegovina.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Bosnien und Herzegowina")]
    [StringValue("BA")]
    Bosnia_And_Herzegovina,

    /// <summary>
    /// Country value for Barbados.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Barbados")]
    [StringValue("BB")]
    Barbados,

    /// <summary>
    /// Country value for Burkina_Faso.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Burkina Faso")]
    [StringValue("BF")]
    Burkina_Faso,

    /// <summary>
    /// Country value for Belgium.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Belgien")]
    [StringValue("BE")]
    Belgium,

    /// <summary>
    /// Country value for Switzerland.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Schweiz")]
    [StringValue("CH")]
    Switzerland,

    /// <summary>
    /// Country value for Germany.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Deutschland")]
    [StringValue("DE")]
    Germany,

    /// <summary>
    /// Country value for Greece.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Griechenland")]
    [StringValue("GR")]
    Greece,

    /// <summary>
    /// Country value for Australia.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Australien")]
    [StringValue("AU")]
    Australia,

    /// <summary>
    /// Country value for Canada.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Kanada")]
    [StringValue("CA")]
    Canada,

    /// <summary>
    /// Country value for Cocos_Islands.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Kokosinseln")]
    [StringValue("CC")]
    Cocos_Islands,

    /// <summary>
    /// Country value for Democratic_Republic_Congo.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Demokratische Republik Kongo")]
    [StringValue("CD")]
    Democratic_Republic_Congo,

    /// <summary>
    /// Country value for Central_African_Republic.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Zentralafrikanische Republik")]
    [StringValue("CF")]
    Central_African_Republic,

    /// <summary>
    /// Country value for United_Kingdom.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Vereinigtes Königreich")]
    [StringValue("GB")]
    United_Kingdom,

    /// <summary>
    /// Country value for Ireland.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Irland")]
    [StringValue("IE")]
    Ireland,

    /// <summary>
    /// Country value for New_Zealand.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Neuseeland")]
    [StringValue("NZ")]
    New_Zealand,

    /// <summary>
    /// Country value for United_States.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Vereinigte Staaten")]
    [StringValue("US")]
    United_States,

    /// <summary>
    /// Country value for Mexico.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Mexiko")]
    [StringValue("MX")]
    Mexico,

    /// <summary>
    /// Country value for Estonia.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Estland")]
    [StringValue("EE")]
    Estonia,

    /// <summary>
    /// Country value for Iran.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Iran")]
    [StringValue("IR")]
    Iran,

    /// <summary>
    /// Country value for Finland.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Finnland")]
    [StringValue("FI")]
    Finland,

    /// <summary>
    /// Country value for France.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Frankreich")]
    [StringValue("FR")]
    France,

    /// <summary>
    /// Country value for Israel.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Israel")]
    [StringValue("IL")]
    Israel,

    /// <summary>
    /// Country value for India.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Indien")]
    [StringValue("IN")]
    India,

    /// <summary>
    /// Country value for Hungary.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Ungarn")]
    [StringValue("HU")]
    Hungary,

    /// <summary>
    /// Country value for Indonesia.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Indonesien")]
    [StringValue("ID")]
    Indonesia,

    /// <summary>
    /// Country value for Italy.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Italien")]
    [StringValue("IT")]
    Italy,

    /// <summary>
    /// Country value for Bailiwick_Of_Guernsey.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Guernsey")]
    [StringValue("GG")]
    Bailiwick_Of_Guernsey,

    /// <summary>
    /// Country value for Japan.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Japan")]
    [StringValue("JP")]
    Japan,

    /// <summary>
    /// Country value for Georgia.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Georgien")]
    [StringValue("GE")]
    Georgia,

    /// <summary>
    /// Country value for Kazakhstan.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Kasachstan")]
    [StringValue("KZ")]
    Kazakhstan,

    /// <summary>
    /// Country value for South_Korea.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Südkorea")]
    [StringValue("KR")]
    South_Korea,

    /// <summary>
    /// Country value for Lithuania.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Litauen")]
    [StringValue("LT")]
    Lithuania,

    /// <summary>
    /// Country value for Latvia.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Lettland")]
    [StringValue("LV")]
    Latvia,

    /// <summary>
    /// Country value for Malaysia.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Malaysia")]
    [StringValue("MY")]
    Malaysia,

    /// <summary>
    /// Country value for Singapore.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Singapur")]
    [StringValue("SG")]
    Singapore,

    /// <summary>
    /// Country value for Norway.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Norwegen")]
    [StringValue("NO")]
    Norway,

    /// <summary>
    /// Country value for Netherlands.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Niederlande")]
    [StringValue("NL")]
    Netherlands,

    /// <summary>
    /// Country value for Poland.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Polen")]
    [StringValue("PL")]
    Poland,

    /// <summary>
    /// Country value for Brazil.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Brasilien")]
    [StringValue("BR")]
    Brazil,

    /// <summary>
    /// Country value for Bahamas.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Bahamas")]
    [StringValue("BS")]
    Bahamas,

    /// <summary>
    /// Country value for Bhutan.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Bhutan")]
    [StringValue("BT")]
    Bhutan,

    /// <summary>
    /// Country value for Bouvet_Island.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Bouvetinsel")]
    [StringValue("BV")]
    Bouvet_Island,

    /// <summary>
    /// Country value for Botswana.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Botswana")]
    [StringValue("BW")]
    Botswana,

    /// <summary>
    /// Country value for Portugal.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Portugal")]
    [StringValue("PT")]
    Portugal,

    /// <summary>
    /// Country value for Romania.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Rumänien")]
    [StringValue("RO")]
    Romania,

    /// <summary>
    /// Country value for Russia.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Russland")]
    [StringValue("RU")]
    Russia,

    /// <summary>
    /// Country value for Sri_Lanka.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Sri Lanka")]
    [StringValue("LK")]
    Sri_Lanka,

    /// <summary>
    /// Country value for Slovakia.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Slowakei")]
    [StringValue("SK")]
    Slovakia,

    /// <summary>
    /// Country value for Slovenia.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Slowenien")]
    [StringValue("SI")]
    Slovenia,

    /// <summary>
    /// Country value for Albania.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Albanien")]
    [StringValue("AL")]
    Albania,

    /// <summary>
    /// Country value for Serbia.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Serbien")]
    [StringValue("RS")]
    Serbia,

    /// <summary>
    /// Country value for Sweden.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Schweden")]
    [StringValue("SE")]
    Sweden,

    /// <summary>
    /// Country value for Thailand.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Thailand")]
    [StringValue("TH")]
    Thailand,

    /// <summary>
    /// Country value for Philippines.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Philippinen")]
    [StringValue("PH")]
    Philippines,

    /// <summary>
    /// Country value for Turkey.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Türkei")]
    [StringValue("TR")]
    Turkey,

    /// <summary>
    /// Country value for Ukraine.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Ukraine")]
    [StringValue("UA")]
    Ukraine,

    /// <summary>
    /// Country value for Vietnam.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Vietnam")]
    [StringValue("VN")]
    Vietnam,

    /// <summary>
    /// Country value for Hong_Kong.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Hongkong")]
    [StringValue("HK")]
    Hong_Kong,

    /// <summary>
    /// Country value for Taiwan.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Taiwan")]
    [StringValue("TW")]
    Taiwan,

    /// <summary>
    /// Country value for South_Africa.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Südafrika")]
    [StringValue("ZA")]
    South_Africa,

    /// <summary>
    /// Country value for Republic_Congo.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Republik Kongo")]
    [StringValue("CG")]
    Republic_Congo,

    /// <summary>
    /// Country value for Cote_D_Ivoire.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Elfenbeinküste")]
    [StringValue("CI")]
    Cote_D_Ivoire,

    /// <summary>
    /// Country value for Cook_Islands.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Cookinseln")]
    [StringValue("CK")]
    Cook_Islands,

    /// <summary>
    /// Country value for Chile.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Chile")]
    [StringValue("CL")]
    Chile,

    /// <summary>
    /// Country value for Cameroon.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Kamerun")]
    [StringValue("CM")]
    Cameroon,

    /// <summary>
    /// Country value for Colombia.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Kolumbien")]
    [StringValue("CO")]
    Colombia,

    /// <summary>
    /// Country value for Costa_Rica.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Costa Rica")]
    [StringValue("CR")]
    Costa_Rica,

    /// <summary>
    /// Country value for Serbia_And_Montenegro.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Serbien und Montenegro")]
    [StringValue("CS")]
    Serbia_And_Montenegro,

    /// <summary>
    /// Country value for Cuba.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Kuba")]
    [StringValue("CU")]
    Cuba,

    /// <summary>
    /// Country value for Cape_Verde.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Kap Verde")]
    [StringValue("CV")]
    Cape_Verde,

    /// <summary>
    /// Country value for Christmas_Island.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Weihnachtsinsel")]
    [StringValue("CX")]
    Christmas_Island,

    /// <summary>
    /// Country value for Cyprus.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Zypern")]
    [StringValue("CY")]
    Cyprus,

    /// <summary>
    /// Country value for Djibouti.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Dschibuti")]
    [StringValue("DJ")]
    Djibouti,

    /// <summary>
    /// Country value for Dominica.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Dominica")]
    [StringValue("DM")]
    Dominica,

    /// <summary>
    /// Country value for Dominican_Republic.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Dominikanische Republik")]
    [StringValue("DO")]
    Dominican_Republic,

    /// <summary>
    /// Country value for Algeria.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Algerien")]
    [StringValue("DZ")]
    Algeria,

    /// <summary>
    /// Country value for Ecuador.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Ecuador")]
    [StringValue("EC")]
    Ecuador,

    /// <summary>
    /// Country value for Egypt.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Ägypten")]
    [StringValue("EG")]
    Egypt,

    /// <summary>
    /// Country value for Western_Sahara.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Westsahara")]
    [StringValue("EH")]
    Western_Sahara,

    /// <summary>
    /// Country value for Eritrea.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Eritrea")]
    [StringValue("ER")]
    Eritrea,

    /// <summary>
    /// Country value for Ethiopia.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Äthiopien")]
    [StringValue("ET")]
    Ethiopia,

    /// <summary>
    /// Country value for Fiji.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Fidschi")]
    [StringValue("FJ")]
    Fiji,

    /// <summary>
    /// Country value for Falkland_Islands.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Falklandinseln")]
    [StringValue("FK")]
    Falkland_Islands,

    /// <summary>
    /// Country value for Micronesia.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Mikronesien")]
    [StringValue("FM")]
    Micronesia,

    /// <summary>
    /// Country value for Faeroe_Islands.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Färöer")]
    [StringValue("FO")]
    Faeroe_Islands,

    /// <summary>
    /// Country value for Gabon.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Gabun")]
    [StringValue("GA")]
    Gabon,

    /// <summary>
    /// Country value for Grenada.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Grenada")]
    [StringValue("GD")]
    Grenada,

    /// <summary>
    /// Country value for French_Guiana.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Französisch-Guayana")]
    [StringValue("GF")]
    French_Guiana,

    /// <summary>
    /// Country value for Ghana.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Ghana")]
    [StringValue("GH")]
    Ghana,

    /// <summary>
    /// Country value for Gibraltar.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Gibraltar")]
    [StringValue("GI")]
    Gibraltar,

    /// <summary>
    /// Country value for Greenland.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Grönland")]
    [StringValue("GL")]
    Greenland,

    /// <summary>
    /// Country value for Gambia.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Gambia")]
    [StringValue("GM")]
    Gambia,

    /// <summary>
    /// Country value for Guinea.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Guinea")]
    [StringValue("GN")]
    Guinea,

    /// <summary>
    /// Country value for Guadaloupe.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Guadeloupe")]
    [StringValue("GP")]
    Guadaloupe,

    /// <summary>
    /// Country value for Equatorial_Guinea.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Äquatorialguinea")]
    [StringValue("GQ")]
    Equatorial_Guinea,

    /// <summary>
    /// Country value for South_Georgia_And_The_South_Sandwich_Islands.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Südgeorgien und die Südlichen Sandwichinseln")]
    [StringValue("GS")]
    South_Georgia_And_The_South_Sandwich_Islands,

    /// <summary>
    /// Country value for Guatemala.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Guatemala")]
    [StringValue("GT")]
    Guatemala,

    /// <summary>
    /// Country value for Guinea_Bissau.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Guinea-Bissau")]
    [StringValue("GW")]
    Guinea_Bissau,

    /// <summary>
    /// Country value for Guyana.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Guyana")]
    [StringValue("GY")]
    Guyana,

    /// <summary>
    /// Country value for Isle_Of_Man.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Isle of Man")]
    [StringValue("IM")]
    Isle_Of_Man,

    /// <summary>
    /// Country value for Jersey.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Jersey")]
    [StringValue("JE")]
    Jersey,

    /// <summary>
    /// Country value for Heard_And_McDonald_Islands.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Heard und McDonaldinseln")]
    [StringValue("HM")]
    Heard_And_McDonald_Islands,

    /// <summary>
    /// Country value for Honduras.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Honduras")]
    [StringValue("HN")]
    Honduras,

    /// <summary>
    /// Country value for Croatia.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Kroatien")]
    [StringValue("HR")]
    Croatia,

    /// <summary>
    /// Country value for Haiti.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Haiti")]
    [StringValue("HT")]
    Haiti,

    /// <summary>
    /// Country value for British_Indian_Ocean_Territory.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Britisches Territorium im Indischen Ozean")]
    [StringValue("IO")]
    British_Indian_Ocean_Territory,

    /// <summary>
    /// Country value for Iraq.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Irak")]
    [StringValue("IQ")]
    Iraq,

    /// <summary>
    /// Country value for Iceland.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Island")]
    [StringValue("IS")]
    Iceland,

    /// <summary>
    /// Country value for Jamaica.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Jamaika")]
    [StringValue("JM")]
    Jamaica,

    /// <summary>
    /// Country value for Jordan.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Jordanien")]
    [StringValue("JO")]
    Jordan,

    /// <summary>
    /// Country value for Kenya.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Kenia")]
    [StringValue("KE")]
    Kenya,

    /// <summary>
    /// Country value for Kyrgyz_Republic.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Kirgisistan")]
    [StringValue("KG")]
    Kyrgyz_Republic,

    /// <summary>
    /// Country value for Cambodia.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Kambodscha")]
    [StringValue("KH")]
    Cambodia,

    /// <summary>
    /// Country value for Kiribati.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Kiribati")]
    [StringValue("KI")]
    Kiribati,

    /// <summary>
    /// Country value for Comoros.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Komoren")]
    [StringValue("KM")]
    Comoros,

    /// <summary>
    /// Country value for St_Kitts_And_Nevis.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "St. Kitts und Nevis")]
    [StringValue("KN")]
    St_Kitts_And_Nevis,

    /// <summary>
    /// Country value for North_Korea.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Nordkorea")]
    [StringValue("KP")]
    North_Korea,

    /// <summary>
    /// Country value for Kuwait.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Kuwait")]
    [StringValue("KW")]
    Kuwait,

    /// <summary>
    /// Country value for Cayman_Islands.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Kaimaninseln")]
    [StringValue("KY")]
    Cayman_Islands,

    /// <summary>
    /// Country value for Laos.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Laos")]
    [StringValue("LA")]
    Laos,

    /// <summary>
    /// Country value for Lebanon.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Libanon")]
    [StringValue("LB")]
    Lebanon,

    /// <summary>
    /// Country value for St_Lucia.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "St. Lucia")]
    [StringValue("LC")]
    St_Lucia,

    /// <summary>
    /// Country value for Liechtenstein.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Liechtenstein")]
    [StringValue("LI")]
    Liechtenstein,

    /// <summary>
    /// Country value for Liberia.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Liberia")]
    [StringValue("LR")]
    Liberia,

    /// <summary>
    /// Country value for Lesotho.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Lesotho")]
    [StringValue("LS")]
    Lesotho,

    /// <summary>
    /// Country value for Luxembourg.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Luxemburg")]
    [StringValue("LU")]
    Luxembourg,

    /// <summary>
    /// Country value for Libya.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Libyen")]
    [StringValue("LY")]
    Libya,

    /// <summary>
    /// Country value for Morocco.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Marokko")]
    [StringValue("MA")]
    Morocco,

    /// <summary>
    /// Country value for Monaco.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Monaco")]
    [StringValue("MC")]
    Monaco,

    /// <summary>
    /// Country value for Moldova.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Moldawien")]
    [StringValue("MD")]
    Moldova,

    /// <summary>
    /// Country value for Montenegro.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Montenegro")]
    [StringValue("ME")]
    Montenegro,

    /// <summary>
    /// Country value for Madagascar.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Madagaskar")]
    [StringValue("MG")]
    Madagascar,

    /// <summary>
    /// Country value for Marshall_Islands.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Marshallinseln")]
    [StringValue("MH")]
    Marshall_Islands,

    /// <summary>
    /// Country value for Macedonia.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Nordmazedonien")]
    [StringValue("MK")]
    Macedonia,

    /// <summary>
    /// Country value for Mali.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Mali")]
    [StringValue("ML")]
    Mali,

    /// <summary>
    /// Country value for Myanmar.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Myanmar")]
    [StringValue("MM")]
    Myanmar,

    /// <summary>
    /// Country value for Collectivity_Of_Saint_Martin.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Saint-Martin")]
    [StringValue("MF")]
    Collectivity_Of_Saint_Martin,

    /// <summary>
    /// Country value for Mongolia.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Mongolei")]
    [StringValue("MN")]
    Mongolia,

    /// <summary>
    /// Country value for Macao.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Macau")]
    [StringValue("MO")]
    Macao,

    /// <summary>
    /// Country value for Northern_Mariana_Islands.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Nördliche Marianen")]
    [StringValue("MP")]
    Northern_Mariana_Islands,

    /// <summary>
    /// Country value for Martinique.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Martinique")]
    [StringValue("MQ")]
    Martinique,

    /// <summary>
    /// Country value for Mauritania.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Mauretanien")]
    [StringValue("MR")]
    Mauritania,

    /// <summary>
    /// Country value for Montserrat.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Montserrat")]
    [StringValue("MS")]
    Montserrat,

    /// <summary>
    /// Country value for Malta.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Malta")]
    [StringValue("MT")]
    Malta,

    /// <summary>
    /// Country value for Mauritius.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Mauritius")]
    [StringValue("MU")]
    Mauritius,

    /// <summary>
    /// Country value for Maldives.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Malediven")]
    [StringValue("MV")]
    Maldives,

    /// <summary>
    /// Country value for Malawi.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Malawi")]
    [StringValue("MW")]
    Malawi,

    /// <summary>
    /// Country value for Mozambique.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Mosambik")]
    [StringValue("MZ")]
    Mozambique,

    /// <summary>
    /// Country value for Namibia.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Namibia")]
    [StringValue("NA")]
    Namibia,

    /// <summary>
    /// Country value for New_Caledonia.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Neukaledonien")]
    [StringValue("NC")]
    New_Caledonia,

    /// <summary>
    /// Country value for Niger.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Niger")]
    [StringValue("NE")]
    Niger,

    /// <summary>
    /// Country value for Norfolk_Island.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Norfolkinsel")]
    [StringValue("NF")]
    Norfolk_Island,

    /// <summary>
    /// Country value for Nigeria.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Nigeria")]
    [StringValue("NG")]
    Nigeria,

    /// <summary>
    /// Country value for Nicaragua.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Nicaragua")]
    [StringValue("NI")]
    Nicaragua,

    /// <summary>
    /// Country value for Nepal.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Nepal")]
    [StringValue("NP")]
    Nepal,

    /// <summary>
    /// Country value for Nauru.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Nauru")]
    [StringValue("NR")]
    Nauru,

    /// <summary>
    /// Country value for Niue.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Niue")]
    [StringValue("NU")]
    Niue,

    /// <summary>
    /// Country value for Oman.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Oman")]
    [StringValue("OM")]
    Oman,

    /// <summary>
    /// Country value for Panama.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Panama")]
    [StringValue("PA")]
    Panama,

    /// <summary>
    /// Country value for Peru.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Peru")]
    [StringValue("PE")]
    Peru,

    /// <summary>
    /// Country value for French_Polynesia.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Französisch-Polynesien")]
    [StringValue("PF")]
    French_Polynesia,

    /// <summary>
    /// Country value for Papua_New_Guinea.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Papua-Neuguinea")]
    [StringValue("PG")]
    Papua_New_Guinea,

    /// <summary>
    /// Country value for Pakistan.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Pakistan")]
    [StringValue("PK")]
    Pakistan,

    /// <summary>
    /// Country value for St_Pierre_And_Miquelon.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Saint-Pierre und Miquelon")]
    [StringValue("PM")]
    St_Pierre_And_Miquelon,

    /// <summary>
    /// Country value for Pitcairn_Island.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Pitcairninseln")]
    [StringValue("PN")]
    Pitcairn_Island,

    /// <summary>
    /// Country value for Puerto_Rico.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Puerto Rico")]
    [StringValue("PR")]
    Puerto_Rico,

    /// <summary>
    /// Country value for Palestinian.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Palästina")]
    [StringValue("PS")]
    Palestinian,

    /// <summary>
    /// Country value for Palau.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Palau")]
    [StringValue("PW")]
    Palau,

    /// <summary>
    /// Country value for Paraguay.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Paraguay")]
    [StringValue("PY")]
    Paraguay,

    /// <summary>
    /// Country value for Qatar.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Katar")]
    [StringValue("QA")]
    Qatar,

    /// <summary>
    /// Country value for Reunion.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Réunion")]
    [StringValue("RE")]
    Reunion,

    /// <summary>
    /// Country value for Rwanda.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Ruanda")]
    [StringValue("RW")]
    Rwanda,

    /// <summary>
    /// Country value for Solomon.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Salomonen")]
    [StringValue("SB")]
    Solomon,

    /// <summary>
    /// Country value for Seychelles.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Seychellen")]
    [StringValue("SC")]
    Seychelles,

    /// <summary>
    /// Country value for Sudan.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Sudan")]
    [StringValue("SD")]
    Sudan,

    /// <summary>
    /// Country value for St_Helena.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "St. Helena, Ascension und Tristan da Cunha")]
    [StringValue("SH")]
    St_Helena,

    /// <summary>
    /// Country value for Svalbard_And_Jan_Mayen.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Spitzbergen und Jan Mayen")]
    [StringValue("SJ")]
    Svalbard_And_Jan_Mayen,

    /// <summary>
    /// Country value for Sierra_Leone.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Sierra Leone")]
    [StringValue("SL")]
    Sierra_Leone,

    /// <summary>
    /// Country value for San_Marino.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "San Marino")]
    [StringValue("SM")]
    San_Marino,

    /// <summary>
    /// Country value for Senegal.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Senegal")]
    [StringValue("SN")]
    Senegal,

    /// <summary>
    /// Country value for Somalia.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Somalia")]
    [StringValue("SO")]
    Somalia,

    /// <summary>
    /// Country value for Suriname.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Suriname")]
    [StringValue("SR")]
    Suriname,

    /// <summary>
    /// Country value for South_Sudan.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Südsudan")]
    [StringValue("SS")]
    South_Sudan,

    /// <summary>
    /// Country value for Sao_Tome_And_Principe.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "São Tomé und Príncipe")]
    [StringValue("ST")]
    Sao_Tome_And_Principe,

    /// <summary>
    /// Country value for Soviet_Union.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Sowjetunion")]
    [StringValue("SU")]
    Soviet_Union,

    /// <summary>
    /// Country value for El_Salvador.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "El Salvador")]
    [StringValue("SV")]
    El_Salvador,

    /// <summary>
    /// Country value for Syria.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Syrien")]
    [StringValue("SY")]
    Syria,

    /// <summary>
    /// Country value for Sint_Maarten.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Sint Maarten")]
    [StringValue("SX")]
    Sint_Maarten,

    /// <summary>
    /// Country value for Swaziland.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Eswatini")]
    [StringValue("SZ")]
    Swaziland,

    /// <summary>
    /// Country value for Turks_And_Caicos_Islands.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Turks- und Caicosinseln")]
    [StringValue("TC")]
    Turks_And_Caicos_Islands,

    /// <summary>
    /// Country value for Chad.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Tschad")]
    [StringValue("TD")]
    Chad,

    /// <summary>
    /// Country value for French_Southern_Territories.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Französische Süd- und Antarktisgebiete")]
    [StringValue("TF")]
    French_Southern_Territories,

    /// <summary>
    /// Country value for Togo.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Togo")]
    [StringValue("TG")]
    Togo,

    /// <summary>
    /// Country value for Tajikistan.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Tadschikistan")]
    [StringValue("TJ")]
    Tajikistan,

    /// <summary>
    /// Country value for Tokelau.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Tokelau")]
    [StringValue("TK")]
    Tokelau,

    /// <summary>
    /// Country value for Timor_Leste.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Timor-Leste")]
    [StringValue("TL")]
    Timor_Leste,

    /// <summary>
    /// Country value for Turkmenistan.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Turkmenistan")]
    [StringValue("TM")]
    Turkmenistan,

    /// <summary>
    /// Country value for Tunisia.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Tunesien")]
    [StringValue("TN")]
    Tunisia,

    /// <summary>
    /// Country value for Tonga.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Tonga")]
    [StringValue("TO")]
    Tonga,

    /// <summary>
    /// Country value for Trinidad_And_Tobago.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Trinidad und Tobago")]
    [StringValue("TT")]
    Trinidad_And_Tobago,

    /// <summary>
    /// Country value for Tuvalu.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Tuvalu")]
    [StringValue("TV")]
    Tuvalu,

    /// <summary>
    /// Country value for Tanzania.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Tansania")]
    [StringValue("TZ")]
    Tanzania,

    /// <summary>
    /// Country value for Uganda.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Uganda")]
    [StringValue("UG")]
    Uganda,

    /// <summary>
    /// Country value for United_States_Minor_Outlying_Islands.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "United States Minor Outlying Islands")]
    [StringValue("UM")]
    United_States_Minor_Outlying_Islands,

    /// <summary>
    /// Country value for Uruguay.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Uruguay")]
    [StringValue("UY")]
    Uruguay,

    /// <summary>
    /// Country value for Uzbekistan.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Usbekistan")]
    [StringValue("UZ")]
    Uzbekistan,

    /// <summary>
    /// Country value for Vatican_City.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Vatikanstadt")]
    [StringValue("VA")]
    Vatican_City,

    /// <summary>
    /// Country value for St_Vincent_And_The_Grenadines.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "St. Vincent und die Grenadinen")]
    [StringValue("VC")]
    St_Vincent_And_The_Grenadines,

    /// <summary>
    /// Country value for Venezuela.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Venezuela")]
    [StringValue("VE")]
    Venezuela,

    /// <summary>
    /// Country value for British_Virgin_Islands.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Britische Jungferninseln")]
    [StringValue("VG")]
    British_Virgin_Islands,

    /// <summary>
    /// Country value for US_Virgin_Islands.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Amerikanische Jungferninseln")]
    [StringValue("VI")]
    US_Virgin_Islands,

    /// <summary>
    /// Country value for Vanuatu.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Vanuatu")]
    [StringValue("VU")]
    Vanuatu,

    /// <summary>
    /// Country value for Wallis_And_Futuna.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Wallis und Futuna")]
    [StringValue("WF")]
    Wallis_And_Futuna,

    /// <summary>
    /// Country value for Samoa.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Samoa")]
    [StringValue("WS")]
    Samoa,

    /// <summary>
    /// Country value for Czechoslovakia.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Tschechoslowakei")]
    [StringValue("XC")]
    Czechoslovakia,

    /// <summary>
    /// Country value for East_Germany.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "")]
    [StringValue("XG")]
    East_Germany,

    /// <summary>
    /// Country value for Kosovo.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Kosovo")]
    [StringValue("XK")]
    Kosovo,

    /// <summary>
    /// Country value for Yemen.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Jemen")]
    [StringValue("YE")]
    Yemen,

    /// <summary>
    /// Country value for Mayotte.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Mayotte")]
    [StringValue("YT")]
    Mayotte,

    /// <summary>
    /// Country value for Yugoslavia.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Jugoslawien")]
    [StringValue("YU")]
    Yugoslavia,

    /// <summary>
    /// Country value for Zambia.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Sambia")]
    [StringValue("ZM")]
    Zambia,

    /// <summary>
    /// Country value for Zimbabwe.
    /// </summary>
    [KeyValuePair(GermanLanguageKey, "Simbabwe")]
    [StringValue("ZW")]
    Zimbabwe
}