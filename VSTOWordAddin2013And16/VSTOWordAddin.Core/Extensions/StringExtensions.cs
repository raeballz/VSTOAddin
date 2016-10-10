//------------------------------------------------------------------
// Copyright (c) 2012 - 2014 Adaptive Apps Ltd. All rights reserved.
// MvvmCross is licensed using Microsoft Public License (Ms-PL)
// Copyright (c) Cirrious Ltd. http://www.cirrious.com
//------------------------------------------------------------------
namespace VSTOWordAddin.Core.Extensions
{
    using System;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// Class representing StringExtensions.
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Encodes the type key.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="type">The type.</param>
        /// <returns>String concatenation of type and identifier.</returns>
        public static string EncodeTypeKey(this string key, Type type)
        {
            return string.Format("{0}-{1}", type, key);
        }

        /// <summary>
        /// Remove embedded double spaces.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>The cleaned string.</returns>
        public static string RemoveDoubleSpaces(this string value)
        {
            var builder = new StringBuilder(value);

            while (builder.ToString().Contains("  "))
            {
                builder.Replace("  ", " ");
            }

            return builder.ToString();
        }

        /// <summary>
        /// Removes the double character.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="target">The target.</param>
        /// <returns>The cleaned string.</returns>
        public static string RemoveDoubleCharacter(this string value, char target)
        {
            var builder = new StringBuilder(value);

            var doubleString = new string(target, 2);
            var singleString = new string(target, 1);
            while (builder.ToString().Contains(doubleString))
            {
                builder.Replace(doubleString, singleString);
            }

            return builder.ToString();
        }

        /// <summary>
        /// Sets the clickable marker.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="set">if set to <c>true</c> [set].</param>
        /// <param name="marker">The marker.</param>
        /// <returns>Updated string with marker added or removed.</returns>
        public static string SetClickableMarker(this string value, bool set, char marker)
        {
            var updatedValue = value.TrimEnd(new[] { ' ', marker });
            return set ? string.Format("{0} {1}", updatedValue, marker) : updatedValue;
        }

        /// <summary>
        /// To the readable string.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="parameter">The parameter.</param>
        /// <returns>A readable version of camel-cased string.</returns>
        public static string ToReadableString(this string value, string parameter = null)
        {
            var stringValue = value.Trim();
            if (string.IsNullOrEmpty(stringValue))
            {
                return stringValue;
            }

            // Can only think of one valid one, for now...
            var breakChars = new[] { '_' };
            var caseShift = 32;

            var casing = parameter;
            var toLower = false;
            var toUpper = false;

            if (casing != null)
            {
                switch (casing.ToLower())
                {
                    case "title":
                        caseShift = 0;
                        break;
                    case "upper":
                        toUpper = true;
                        break;
                    case "lower":
                        toLower = true;
                        break;
                }
            }

            var returnValue = new StringBuilder(stringValue[0].ToString().ToUpper());
            for (var charIndex = 1; charIndex < stringValue.Length; charIndex++)
            {
                if (breakChars.Contains(stringValue[charIndex]))
                {
                    // do not write break char to output...
                }
                else if (stringValue[charIndex] > 47 && stringValue[charIndex] < 58)
                {
                    var lastChar = returnValue.ToString()[returnValue.Length - 1];
                    if (!(lastChar > 47 && lastChar < 58))
                    {
                        returnValue.Append(" ");
                    }

                    returnValue.Append(stringValue[charIndex]);
                }
                else if (stringValue[charIndex] > 64 && stringValue[charIndex] < 91)
                {
                    returnValue.Append(" ");
                    returnValue.Append((char)(stringValue[charIndex] + caseShift));
                }
                else
                {
                    returnValue.Append(stringValue[charIndex]);
                }
            }

            var returnString = returnValue.ToString().Trim();

            return toLower ? returnString.ToLower() : toUpper ? returnString.ToUpper() : returnString;
        }
        
        /// <summary>
        /// To the title case.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>Title Case version of the string.</returns>
        public static string ToTitleCase(this string input)
        {
            var inputTrimmed = input.Trim();
            var breakers = " .-".ToCharArray();
            var ruleExceptions = new[] { " A ", " An ", " And ", " Any ", " At ", " From ", " Into ", " Of ", " On ", " Or ", " To " };
            var returnValue = new StringBuilder(inputTrimmed.Length);
            var needsCapitalisation = true;

            foreach (char character in input)
            {
                returnValue.Append(needsCapitalisation ? char.ToUpper(character) : char.ToLower(character));
                needsCapitalisation = breakers.Contains(character);
            }

            foreach (var ruleException in ruleExceptions)
            {
                returnValue.Replace(ruleException, ruleException.ToLowerInvariant());
            }

            return returnValue.ToString();
        }

        /// <summary>
        /// Determines whether the specified input has a value.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns><c>true</c> if the specified input has value; otherwise, <c>false</c>.</returns>
        public static bool HasValue(this string input)
        {
            return !string.IsNullOrEmpty(input);
        }

        /// <summary>
        /// Truncates the string to the specified maximum length.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <param name="maximumLength">The maximum length.</param>
        /// <returns>The truncated string.</returns>
        public static string Truncate(this string input, int maximumLength)
        {
            return input.HasValue() && input.Length > maximumLength
                ? input.Substring(0, maximumLength - 3) + "..."
                : input;
        }
    }
}