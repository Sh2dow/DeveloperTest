using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2.DeveloperTest.Constants
{
    public static class Constant
    {
        #region Public Error Message Constants

        // Public error message constants.
        public const string InvalidFormatErrorMessage = "Please provide the {0} in a valid format.";
        public const string RequiredErrorMessage = "Please provide the {0}.";

        #endregion

        #region Public Misc Constants

        // Public misc cnstants.
        public const string SystemEmail = "system@m2mediagroup.com";

        #endregion

        #region Public Regular Expression Constants

        // Public regular expression constants.
        public const string ZipRegularExpression = @"^(\d{5}-\d{4}|\d{5}|\d{9})$";

        #endregion

        #region Public State Constants

        // Public military state constants.
        public const string MilitaryState1 = "AA";
        public const string MilitaryState2 = "AE";
        public const string MilitaryState3 = "AP";

        // Public state constants.
        public const string State1 = "AL";
        public const string State2 = "AK";
        public const string State3 = "AR";
        public const string State4 = "AZ";
        public const string State5 = "CA";
        public const string State6 = "CO";
        public const string State7 = "CT";
        public const string State8 = "DE";
        public const string State9 = "DC";
        public const string State10 = "FL";
        public const string State11 = "GA";
        public const string State12 = "HI";
        public const string State13 = "ID";
        public const string State14 = "IL";
        public const string State15 = "IN";
        public const string State16 = "IA";
        public const string State17 = "KS";
        public const string State18 = "KY";
        public const string State19 = "LA";
        public const string State20 = "ME";
        public const string State21 = "MD";
        public const string State22 = "MA";
        public const string State23 = "MI";
        public const string State24 = "MN";
        public const string State25 = "MS";
        public const string State26 = "MO";
        public const string State27 = "MT";
        public const string State28 = "NE";
        public const string State29 = "NV";
        public const string State30 = "NH";
        public const string State31 = "NJ";
        public const string State32 = "NM";
        public const string State33 = "NY";
        public const string State34 = "NC";
        public const string State35 = "ND";
        public const string State36 = "OH";
        public const string State37 = "OK";
        public const string State38 = "OR";
        public const string State39 = "PA";
        public const string State40 = "RI";
        public const string State41 = "SC";
        public const string State42 = "SD";
        public const string State43 = "TN";
        public const string State44 = "TX";
        public const string State45 = "UT";
        public const string State46 = "VT";
        public const string State47 = "VA";
        public const string State48 = "WA";
        public const string State49 = "WV";
        public const string State50 = "WI";
        public const string State51 = "WY";

        // Public territory state constants.
        public const string TerritoryState1 = "GU";
        public const string TerritoryState2 = "PR";
        public const string TerritoryState3 = "VI";
        public const string TerritoryState4 = "AS";
        public const string TerritoryState5 = "FM";
        public const string TerritoryState6 = "MH";
        public const string TerritoryState7 = "MP";
        public const string TerritoryState8 = "PW";

        #endregion

        #region Public Static Fields

        // Full state list.
        public static List<string> StateList = new List<string> {
            MilitaryState1,
            MilitaryState2,
            State2,
            State1,
            MilitaryState3,
            State3,
            TerritoryState4,
            State4,
            State5,
            State6,
            State7,
            State9,
            State8,
            State10,
            TerritoryState5,
            State11,
            TerritoryState1,
            State12,
            State16,
            State13,
            State14,
            State15,
            State17,
            State18,
            State19,
            State22,
            State21,
            State20,
            TerritoryState6,
            State23,
            State24,
            State26,
            TerritoryState7,
            State25,
            State27,
            State34,
            State35,
            State28,
            State30,
            State31,
            State32,
            State29,
            State33,
            State36,
            State37,
            State38,
            State39,
            TerritoryState2,
            TerritoryState8,
            State40,
            State41,
            State42,
            State43,
            State44,
            State45,
            State47,
            TerritoryState3,
            State46,
            State48,
            State50,
            State49,
            State51
        };

        #endregion
    }
}
