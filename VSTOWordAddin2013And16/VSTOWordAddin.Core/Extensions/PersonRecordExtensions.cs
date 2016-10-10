//------------------------------------------------------------------
//
// Copyright (c) 2012 - 2014 Adaptive Apps Ltd. All rights reserved.
//
// MvvmCross is licensed using Microsoft Public License (Ms-PL)
// Copyright (c) Cirrious Ltd. http://www.cirrious.com
//
//------------------------------------------------------------------

namespace VSTOWordAddin.Core.Extensions
{
    using Interfaces;

    /// <summary>
    /// Class to convert a person name into a single string for display
    /// </summary>
    public static class PersonRecordExtensions
    {
        /// <summary>
        /// Gets the display name.
        /// </summary>
        /// <param name="personRecord">The person record.</param>
        /// <returns>The name as a single string.</returns>
        /// <remarks>This code was extracted from Person.cs, so see that file for history.</remarks>
        public static string GetFormattedDisplayName(this IPersonRecord personRecord)
        {
            if (string.IsNullOrEmpty(personRecord.GivenName) && string.IsNullOrEmpty(personRecord.FamilyName))
            {
                // We have no name so return ""
                return string.Empty;
            }
            
            var formattedTitle = personRecord.GetFormattedTitle();
            
            if (formattedTitle.HasValue())
            {
                return string.Format("{0}, {1} ({2})", personRecord.GetFormattedFamilyName(), personRecord.GetFormattedGivenName(), formattedTitle);
            }

            return string.Format("{0}, {1}", personRecord.GetFormattedFamilyName(), personRecord.GetFormattedGivenName());
        }

        /// <summary>
        /// Gets the formatted family name.
        /// </summary>
        /// <param name="personRecord">The person record.</param>
        /// <returns>The formatted family name.</returns>
        public static string GetFormattedFamilyName(this IPersonRecord personRecord)
        {
            return personRecord.FamilyName.ToUpper();
        }

        /// <summary>
        /// Gets the formatted given name.
        /// </summary>
        /// <param name="personRecord">The person record.</param>
        /// <returns>The formatted given name.</returns>
        public static string GetFormattedGivenName(this IPersonRecord personRecord)
        {
            return CapitalizeFirstLetter(personRecord.GivenName);
        }

        /// <summary>
        /// Gets the formatted title.
        /// </summary>
        /// <param name="personRecord">The person record.</param>
        /// <returns>The formatted title.</returns>
        public static string GetFormattedTitle(this IPersonRecord personRecord)
        {
            return CapitalizeFirstLetter(personRecord.Title);
        }

        /// <summary>
        /// Capitalizes the first letter of a word.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <returns>The text with a capitalized first letter.</returns>
        private static string CapitalizeFirstLetter(string text)
        {
            if (text.HasValue())
            {
                var firstLetter = text.Substring(0, 1).ToUpper();
                var remainingText = text.Length > 1 ? text.Substring(1).ToLower() : string.Empty;
                return string.Concat(firstLetter, remainingText);
            }

            return string.Empty;
        }
    }
}
