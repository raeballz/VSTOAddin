//------------------------------------------------------------------
//
// Copyright (c) 2012 - 2014 Adaptive Apps Ltd. All rights reserved.
// 
// MvvmCross is licensed using Microsoft Public License (Ms-PL)
// Copyright (c) Cirrious Ltd. http://www.cirrious.com
//
//------------------------------------------------------------------

namespace VSTOWordAddin.Core.Helpers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml.Linq;
    using VSTOWordAddin.Core.Models;

    /// <summary>
    /// Class containing helper functions for person gender
    /// </summary>
    public static class GenderHelper
    {
        /// <summary>
        /// Converts a gender string to an enumerated gender value
        /// </summary>
        /// <param name="gender">The gender string to convert</param>
        /// <returns>The value of the element</returns>
        public static Gender GenderStringToGenderValue(string gender)
        {
            Gender g = Gender.NotKnown;

            switch (gender.ToUpper())
            {
                case "MALE":
                    {
                        g = Gender.Male;
                        break;
                    }

                case "FEMALE":
                    {
                        g = Gender.Female;
                        break;
                    }

                default:
                    {
                        g = Gender.NotKnown;
                        break;
                    }
            }

            return g;
        }

        /// <summary>
        /// Converts a gender string to an enumerated gender value
        /// </summary>
        /// <param name="gender">The gender string to convert</param>
        /// <returns>The value of the element</returns>
        public static string GenderValueToGenderString(Gender gender)
        {
            string g;

            switch (gender)
            {
                case Gender.Male:
                    {
                        g = "Male";
                        break;
                    }

                case Gender.Female:
                    {
                        g = "Female";
                        break;
                    }

                default:
                    {
                        g = "Not Known";
                        break;
                    }
            }

            return g;
        }
    }
}
