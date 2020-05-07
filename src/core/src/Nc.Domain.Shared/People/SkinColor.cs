using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Nc.People
{
    /// <summary>
    /// Skin Colors according to von Luschan's chromatic scale
    /// Although abandoned in the early 1950s and replaced with methods utilizing reflectance spectrophotometry, 
    /// this is a 'generic' range of colors for people to choose from.
    /// https://en.wikipedia.org/wiki/Von_Luschan%27s_chromatic_scale
    /// </summary>
    public enum SkinColor
    {
        NotSpecified = -1,
        PreferNotToSay = 0,
        [Description("f4f2f5")]
        One = 1,
        [Description("ecebe9")]
        Two = 2,
        [Description("faf9f7")]
        Three = 3,
        [Description("fdfbe6")]
        Four = 4,
        [Description("fdf6e6")]
        Five = 5,
        [Description("fef7e5")]
        Six = 6,
        [Description("faf0ef")]
        Seven = 7,
        [Description("f3eae5")]
        Eight = 8,
        [Description("f4f1ea")]
        Nine = 9,
        [Description("fbfcf4")]
        Ten = 10,
        [Description("fcf8ed")]
        Eleven = 11,
        [Description("fef6e1")]
        Twelve = 12,
        [Description("fff9e1")]
        Thirteen = 13,
        [Description("fff9e2")]
        Fourteen = 14,  // the color in the image was the same as 13, so slightly modified
        [Description("f1e7c3")]
        Fifteen = 15,
        [Description("efe2ad")]
        Sixteen = 16,
        [Description("e0d293")]
        Seventeen = 17,
        [Description("f2e297")]
        Eighteen = 18,
        [Description("ebd69f")]
        Nineteen = 19,
        [Description("ebd985")]
        Twenty = 20,
        [Description("e3c467")]
        TwentyOne = 21,
        [Description("e1c16a")]
        TwentyTwo = 22,
        [Description("dfc17b")]
        TwentyThree = 23,
        [Description("deb877")]
        TwentyFour = 24,
        [Description("c7a464")]
        TwentyFive = 25,
        [Description("bc9762")]
        TwentySix = 26,
        [Description("9c6b43")]
        TwentySeven = 27,
        [Description("8e583e")]
        TwentyEight = 28,
        [Description("794d30")]
        TwentyNine = 29,
        [Description("643116")]
        Thirty = 30,
        [Description("653020")]
        ThirtyOne = 31,
        [Description("603121")]
        ThirtyTwo = 32,
        [Description("573229")]
        ThirtyThree = 33,
        [Description("402015")]
        ThirtyFour = 34,
        [Description("312529")]
        ThirtyFive = 35,
        [Description("1b1c2e")]
        ThirtySix = 36
    }
}
