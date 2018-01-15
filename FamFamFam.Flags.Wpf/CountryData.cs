/*
 * Created by Drew Noakes
 * 17 April 2017
 * https://drewnoakes.com
 */

using System;
using System.Collections.Generic;
using System.Linq;

namespace FamFamFam.Flags.Wpf
{
    /// <summary>
    /// Reference data and utility methods for working with country data such as ISO 3166-1 alpha-2 codes and names (in English).
    /// </summary>
    public struct CountryData
    {
        private static readonly Dictionary<string, string> _englishNameByIso2 = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {
            // NOTE FamFamFam Flags includes images for non-ISO 3166-1 entities: an, catalonia, cs, en, eu, scotland, wales
            // NOTE FamFamFam Flags doesn't cover these ISO 3166-1 entities

//            {"AQ", "Antarctica"},
//            {"BQ", "Bonaire, Sint Eustatius and Saba"},
//            {"CW", "Curaçao"},
//            {"IM", "Isle of Man"},
//            {"JE", "Jersey"},
//            {"BL", "Saint Barthélemy"},
//            {"MF", "Saint Martin (French part)"},
//            {"SX", "Sint Maarten (Dutch part)"},
//            {"SS", "South Sudan"},

            {"AF", "Afghanistan"},
            {"AX", "Åland Islands"},
            {"AL", "Albania"},
            {"DZ", "Algeria"},
            {"AS", "American Samoa"},
            {"AD", "Andorra"},
            {"AO", "Angola"},
            {"AI", "Anguilla"},
            {"AG", "Antigua and Barbuda"},
            {"AR", "Argentina"},
            {"AM", "Armenia"},
            {"AW", "Aruba"},
            {"AU", "Australia"},
            {"AT", "Austria"},
            {"AZ", "Azerbaijan"},
            {"BS", "Bahamas"},
            {"BH", "Bahrain"},
            {"BD", "Bangladesh"},
            {"BB", "Barbados"},
            {"BY", "Belarus"},
            {"BE", "Belgium"},
            {"BZ", "Belize"},
            {"BJ", "Benin"},
            {"BM", "Bermuda"},
            {"BT", "Bhutan"},
            {"BO", "Bolivia, Plurinational State of"},
            {"BA", "Bosnia and Herzegovina"},
            {"BW", "Botswana"},
            {"BV", "Bouvet Island"},
            {"BR", "Brazil"},
            {"IO", "British Indian Ocean Territory"},
            {"BN", "Brunei Darussalam"},
            {"BG", "Bulgaria"},
            {"BF", "Burkina Faso"},
            {"BI", "Burundi"},
            {"KH", "Cambodia"},
            {"CM", "Cameroon"},
            {"CA", "Canada"},
            {"CV", "Cape Verde"},
            {"KY", "Cayman Islands"},
            {"CF", "Central African Republic"},
            {"TD", "Chad"},
            {"CL", "Chile"},
            {"CN", "China"},
            {"CX", "Christmas Island"},
            {"CC", "Cocos (Keeling) Islands"},
            {"CO", "Colombia"},
            {"KM", "Comoros"},
            {"CG", "Congo"},
            {"CD", "Congo, the Democratic Republic of the"},
            {"CK", "Cook Islands"},
            {"CR", "Costa Rica"},
            {"CI", "Côte d'Ivoire"},
            {"HR", "Croatia"},
            {"CU", "Cuba"},
            {"CY", "Cyprus"},
            {"CZ", "Czech Republic"},
            {"DK", "Denmark"},
            {"DJ", "Djibouti"},
            {"DM", "Dominica"},
            {"DO", "Dominican Republic"},
            {"EC", "Ecuador"},
            {"EG", "Egypt"},
            {"SV", "El Salvador"},
            {"GQ", "Equatorial Guinea"},
            {"ER", "Eritrea"},
            {"EE", "Estonia"},
            {"ET", "Ethiopia"},
            {"FK", "Falkland Islands (Malvinas)"},
            {"FO", "Faroe Islands"},
            {"FJ", "Fiji"},
            {"FI", "Finland"},
            {"FR", "France"},
            {"GF", "French Guiana"},
            {"PF", "French Polynesia"},
            {"TF", "French Southern Territories"},
            {"GA", "Gabon"},
            {"GM", "Gambia"},
            {"GE", "Georgia"},
            {"DE", "Germany"},
            {"GH", "Ghana"},
            {"GI", "Gibraltar"},
            {"GR", "Greece"},
            {"GL", "Greenland"},
            {"GD", "Grenada"},
            {"GP", "Guadeloupe"},
            {"GU", "Guam"},
            {"GT", "Guatemala"},
            {"GG", "Guernsey"},
            {"GN", "Guinea"},
            {"GW", "Guinea-Bissau"},
            {"GY", "Guyana"},
            {"HT", "Haiti"},
            {"HM", "Heard Island and McDonald Islands"},
            {"VA", "Holy See (Vatican City State)"},
            {"HN", "Honduras"},
            {"HK", "Hong Kong"},
            {"HU", "Hungary"},
            {"IS", "Iceland"},
            {"IN", "India"},
            {"ID", "Indonesia"},
            {"IR", "Iran, Islamic Republic of"},
            {"IQ", "Iraq"},
            {"IE", "Ireland"},
            {"IL", "Israel"},
            {"IT", "Italy"},
            {"JM", "Jamaica"},
            {"JP", "Japan"},
            {"JO", "Jordan"},
            {"KZ", "Kazakhstan"},
            {"KE", "Kenya"},
            {"KI", "Kiribati"},
            {"KP", "Korea, Democratic People's Republic of"},
            {"KR", "Korea, Republic of"},
            {"KW", "Kuwait"},
            {"KG", "Kyrgyzstan"},
            {"LA", "Lao People's Democratic Republic"},
            {"LV", "Latvia"},
            {"LB", "Lebanon"},
            {"LS", "Lesotho"},
            {"LR", "Liberia"},
            {"LY", "Libya"},
            {"LI", "Liechtenstein"},
            {"LT", "Lithuania"},
            {"LU", "Luxembourg"},
            {"MO", "Macao"},
            {"MK", "Macedonia, the Former Yugoslav Republic of"},
            {"MG", "Madagascar"},
            {"MW", "Malawi"},
            {"MY", "Malaysia"},
            {"MV", "Maldives"},
            {"ML", "Mali"},
            {"MT", "Malta"},
            {"MH", "Marshall Islands"},
            {"MQ", "Martinique"},
            {"MR", "Mauritania"},
            {"MU", "Mauritius"},
            {"YT", "Mayotte"},
            {"MX", "Mexico"},
            {"FM", "Micronesia, Federated States of"},
            {"MD", "Moldova, Republic of"},
            {"MC", "Monaco"},
            {"MN", "Mongolia"},
            {"ME", "Montenegro"},
            {"MS", "Montserrat"},
            {"MA", "Morocco"},
            {"MZ", "Mozambique"},
            {"MM", "Myanmar"},
            {"NA", "Namibia"},
            {"NR", "Nauru"},
            {"NP", "Nepal"},
            {"NL", "Netherlands"},
            {"NC", "New Caledonia"},
            {"NZ", "New Zealand"},
            {"NI", "Nicaragua"},
            {"NE", "Niger"},
            {"NG", "Nigeria"},
            {"NU", "Niue"},
            {"NF", "Norfolk Island"},
            {"MP", "Northern Mariana Islands"},
            {"NO", "Norway"},
            {"OM", "Oman"},
            {"PK", "Pakistan"},
            {"PW", "Palau"},
            {"PS", "Palestine, State of"},
            {"PA", "Panama"},
            {"PG", "Papua New Guinea"},
            {"PY", "Paraguay"},
            {"PE", "Peru"},
            {"PH", "Philippines"},
            {"PN", "Pitcairn"},
            {"PL", "Poland"},
            {"PT", "Portugal"},
            {"PR", "Puerto Rico"},
            {"QA", "Qatar"},
            {"RE", "Réunion"},
            {"RO", "Romania"},
            {"RU", "Russian Federation"},
            {"RW", "Rwanda"},
            {"SH", "Saint Helena, Ascension and Tristan da Cunha"},
            {"KN", "Saint Kitts and Nevis"},
            {"LC", "Saint Lucia"},
            {"PM", "Saint Pierre and Miquelon"},
            {"VC", "Saint Vincent and the Grenadines"},
            {"WS", "Samoa"},
            {"SM", "San Marino"},
            {"ST", "Sao Tome and Principe"},
            {"SA", "Saudi Arabia"},
            {"SN", "Senegal"},
            {"RS", "Serbia"},
            {"SC", "Seychelles"},
            {"SL", "Sierra Leone"},
            {"SG", "Singapore"},
            {"SK", "Slovakia"},
            {"SI", "Slovenia"},
            {"SB", "Solomon Islands"},
            {"SO", "Somalia"},
            {"ZA", "South Africa"},
            {"GS", "South Georgia and the South Sandwich Islands"},
            {"ES", "Spain"},
            {"LK", "Sri Lanka"},
            {"SD", "Sudan"},
            {"SR", "Suriname"},
            {"SJ", "Svalbard and Jan Mayen"},
            {"SZ", "Swaziland"},
            {"SE", "Sweden"},
            {"CH", "Switzerland"},
            {"SY", "Syrian Arab Republic"},
            {"TW", "Taiwan, Province of China"},
            {"TJ", "Tajikistan"},
            {"TZ", "Tanzania, United Republic of"},
            {"TH", "Thailand"},
            {"TL", "Timor-Leste"},
            {"TG", "Togo"},
            {"TK", "Tokelau"},
            {"TO", "Tonga"},
            {"TT", "Trinidad and Tobago"},
            {"TN", "Tunisia"},
            {"TR", "Turkey"},
            {"TM", "Turkmenistan"},
            {"TC", "Turks and Caicos Islands"},
            {"TV", "Tuvalu"},
            {"UG", "Uganda"},
            {"UA", "Ukraine"},
            {"AE", "United Arab Emirates"},
            {"GB", "United Kingdom"},
            {"US", "United States"},
            {"UM", "United States Minor Outlying Islands"},
            {"UY", "Uruguay"},
            {"UZ", "Uzbekistan"},
            {"VU", "Vanuatu"},
            {"VE", "Venezuela, Bolivarian Republic of"},
            {"VN", "Viet Nam"},
            {"VG", "Virgin Islands, British"},
            {"VI", "Virgin Islands, U.S."},
            {"WF", "Wallis and Futuna"},
            {"EH", "Western Sahara"},
            {"YE", "Yemen"},
            {"ZM", "Zambia"},
            {"ZW", "Zimbabwe"}
        };

        /// <summary>
        /// Returns an enumerable set of country ids supported by this set of flags.
        /// </summary>
        public static IEnumerable<string> AllCountryIds => _englishNameByIso2.Keys;

        /// <summary>
        /// Returns data for all countries that have flag images.
        /// </summary>
        public static IEnumerable<CountryData> AllCountries => _englishNameByIso2.Select(pair => new CountryData(pair.Key, pair.Value));

        /// <summary>
        /// Look up the name of the country identified by <paramref name="iso2"/>.
        /// </summary>
        /// <param name="iso2">The ISO 3166-1 alpha-2 country code to look up.</param>
        /// <param name="name">The country name.</param>
        /// <returns><c>true</c> if the name was found, otherwise <c>false</c>.</returns>
        public static bool TryGetName(string iso2, out string name) => _englishNameByIso2.TryGetValue(iso2, out name);

        /// <summary>
        /// The country's identifier, according to ISO 3166-1 alpha-2.
        /// </summary>
        public string Iso2 { get; }

        /// <summary>
        /// The country's common name, in English.
        /// </summary>
        public string Name { get; }

        private CountryData(string iso2, string name)
        {
            Iso2 = iso2;
            Name = name;
        }
    }
}
