//------------------------------------------------------------------
//
// Copyright (c) 2012 - 2014 Adaptive Apps Ltd. All rights reserved.
// 
// MvvmCross is licensed using Microsoft Public License (Ms-PL)
// Copyright (c) Cirrious Ltd. http://www.cirrious.com
//
//------------------------------------------------------------------

namespace VSTOWordAddin.Core.Models
{
    using System.Collections.Generic;
    using System.ComponentModel;

    /// <summary>
    /// Class representing an Allergy
    /// </summary>
    public class Allergy 
    {
        /// <summary>
        /// The Allergy certainty
        /// </summary>
        private AllergyCertainty certainty;

        /// <summary>
        /// The allergy severity
        /// </summary>
        private AllergySeverity severity;

        /// <summary>
        /// The allergy reaction
        /// </summary>
        private AllergyReaction reaction;

        /// <summary>
        /// Initializes a new instance of the <see cref="Allergy" /> class
        /// </summary>
        public Allergy()
        {
            this.Certainty = AllergyCertainty.NotKnown;
            this.Severity = AllergySeverity.NotKnown;
           
        }

        /// <summary>
        /// Defines different Allergy reactions
        /// </summary>
        public enum AllergyReaction
        {
            /// <summary>
            /// The reaction is not know
            /// </summary>
            NotKnown = -1,

            /// <summary>
            /// The reaction is an Allergy
            /// </summary>
            Allergy = 0,

            /// <summary>
            /// The reaction is an intolerance
            /// </summary>
            Intolerance = 1,

            /// <summary>
            /// The reaction is an Adverse Effect
            /// </summary>
            AdverseEffect = 2
        }

        /// <summary>
        /// Defines different levels of severity for an Allergy
        /// </summary>
        public enum AllergySeverity
        {
            /// <summary>
            /// The Severity is not known
            /// </summary>
            NotKnown = -1,

            /// <summary>
            /// The Severity is Minimal
            /// </summary>
            Minimal = 0,

            /// <summary>
            /// The Severity is Mild
            /// </summary>
            Mild = 1,

            /// <summary>
            /// The Severity is Moderate
            /// </summary>
            Moderate = 2,

            /// <summary>
            /// The Severity is Severe
            /// </summary>
            Severe = 3,

            /// <summary>
            /// The Severity is Very Severe
            /// </summary>
            VerySevere = 4,

            /// <summary>
            /// The Severity is Potentially Fatal
            /// </summary>
            PotentiallyFatal = 5
        }

        /// <summary>
        /// Defines different levels of certainty for an Allergy
        /// </summary>
        public enum AllergyCertainty
        {
            /// <summary>
            /// The Certainty is Not Know
            /// </summary>
            NotKnown = -1,

            /// <summary>
            /// The Certainty is Tentative
            /// </summary>
            Tentative = 0,

            /// <summary>
            /// The Certainty is Unlikely
            /// </summary>
            Unlikely = 1,

            /// <summary>
            /// The Certainty is Possible
            /// </summary>
            Possible = 2,

            /// <summary>
            /// The Certainty is Likely
            /// </summary>
            Likely = 3,

            /// <summary>
            /// The Certainty is Certain
            /// </summary>
            Certain = 4,

            /// <summary>
            /// The Certainty is Absolute
            /// </summary>
            Absolute = 5
        }

        /// <summary>
        /// Defines different allergy states for a patient
        /// </summary>
        public enum PatientAllergyState : int
        {
            /// <summary>
            /// Unable to access allergy information for the patient
            /// </summary>
            AllergiesUnavailable = -1,

            /// <summary>
            /// Not clear whether the patient does or does not have allergies
            /// </summary>
            AllergiesNotRecorded = 0,

            /// <summary>
            /// There is a definitive statement by a clinician that this patient has no known allergies
            /// </summary>
            NoKnownAllergies = 1,

            /// <summary>
            /// There known recorded allergies for this patient
            /// </summary>
            KnownAllergies = 2
        }
        
        /// <summary>
        /// Gets or sets the Allergy certainty
        /// </summary>
      
        public AllergyCertainty Certainty
        {
            get
            {
                return this.certainty;
            }

            set
            {
                this.certainty = value;
            }
        }

        /// <summary>
        /// Gets or sets the allergy severity
        /// </summary>
        public AllergySeverity Severity
        {
            get
            {
                return this.severity;
            }

            set
            {
                this.severity = value;
            }
        }

        /// <summary>
        /// Gets or sets the allergy reaction
        /// </summary>
        public AllergyReaction Reaction
        {
            get
            {
                return this.reaction;
            }

            set
            {
                this.reaction = value;
            }
        }

        /// <summary>
        /// Gets a description of the Allergy's Certainty, Severity and Reaction formatted for display
        /// </summary>
        public string DisplayAllergyDescription
        {
            get 
            {
                return this.GetDisplayAllergyDescription();
            }
        }

        /// <summary>
        /// Returns a text description for an Allergy Reaction
        /// </summary>
        /// <param name="reaction">An Allergy Reaction</param>
        /// <returns>A string description for an Allergy Reaction</returns>
        public static string AllergyReactionDescriptionFromID(AllergyReaction reaction)
        {
            string description = "Not Known";

            switch (reaction)
            {
                case AllergyReaction.NotKnown:
                    description = "Not Known";
                    break;

                case AllergyReaction.Allergy:
                    description = "Allergy";
                    break;

                case AllergyReaction.Intolerance:
                    description = "Intolerance";
                    break;

                case AllergyReaction.AdverseEffect:
                    description = "Adverse Effect";
                    break;
            }

            return description;
        }

        /// <summary>
        /// Returns an Allergy Reaction ID from a text description
        /// </summary>
        /// <param name="reaction">An Allergy Reaction description</param>
        /// <returns>An Allergy Reaction ID</returns>
        public static AllergyReaction AllergyReactionIDFromDescription(string reaction)
        {
            AllergyReaction id = AllergyReaction.NotKnown;

            switch (reaction.ToLower())
            {
                case "not known":
                    id = AllergyReaction.NotKnown;
                    break;

                case "allergy":
                    id = AllergyReaction.Allergy;
                    break;

                case "intolerance":
                    id = AllergyReaction.Intolerance;
                    break;

                case "adverse effect":
                    id = AllergyReaction.AdverseEffect;
                    break;
            }

            return id;
        }

        /// <summary>
        /// Returns a text description for an Allergy Severity level
        /// </summary>
        /// <param name="severity">An Allergy Severity level</param>
        /// <returns>A string description for an Allergy Severity level</returns>
        public static string AllergySeverityDescriptionFromID(AllergySeverity severity)
        {
            string description = "Not Known";

            switch (severity)
            {
                case AllergySeverity.NotKnown:
                    description = "Not Known";
                    break;

                case AllergySeverity.Minimal:
                    description = "Minimal";
                    break;

                case AllergySeverity.Mild:
                    description = "Mild";
                    break;

                case AllergySeverity.Moderate:
                    description = "Moderate";
                    break;

                case AllergySeverity.Severe:
                    description = "Severe";
                    break;

                case AllergySeverity.VerySevere:
                    description = "Very Severe";
                    break;

                case AllergySeverity.PotentiallyFatal:
                    description = "Potentially Fatal";
                    break;
            }

            return description;
        }

        /// <summary>
        /// Returns an Allergy Severity level from a text description for 
        /// </summary>
        /// <param name="severity">An Allergy Severity description</param>
        /// <returns>An Allergy Severity level</returns>
        public static AllergySeverity AllergySeverityIDFromDescription(string severity)
        {
            AllergySeverity level = AllergySeverity.NotKnown;

            switch (severity.ToLower())
            {
                case "not known":
                    level = AllergySeverity.NotKnown;
                    break;

                case "minimal":
                    level = AllergySeverity.Minimal;
                    break;

                case "mild":
                    level = AllergySeverity.Mild;
                    break;

                case "moderate":
                    level = AllergySeverity.Moderate;
                    break;

                case "severe":
                    level = AllergySeverity.Severe;
                    break;

                case "very severe":
                    level = AllergySeverity.VerySevere;
                    break;

                case "potentially fatal":
                    level = AllergySeverity.PotentiallyFatal;
                    break;
            }

            return level;
        }

        /// <summary>
        /// Returns an Allergy Certainty level from a text description for 
        /// </summary>
        /// <param name="certainty">An Allergy Certainty description</param>
        /// <returns>An Allergy Certainty level</returns>
        public static AllergyCertainty AllergyCertaintyIDFromDescription(string certainty)
        {
            AllergyCertainty level = AllergyCertainty.NotKnown;

            switch (certainty.ToLower())
            {
                case "not known":
                    level = AllergyCertainty.NotKnown;
                    break;
                case "tentative":
                    level = AllergyCertainty.Tentative;
                    break;
                case "unlikely":
                    level = AllergyCertainty.Unlikely;
                    break;
                case "possible":
                    level = AllergyCertainty.Possible;
                    break;
                case "likely":
                    level = AllergyCertainty.Likely;
                    break;
                case "certain":
                    level = AllergyCertainty.Certain;
                    break;
                case "absolute":
                    level = AllergyCertainty.Absolute;
                    break;
            }

            return level;
        }

        /// <summary>
        /// Returns a text description for an Allergy Certainty level
        /// </summary>
        /// <param name="certainty">An Allergy Certainty level</param>
        /// <returns>A string description for an Allergy Certainty level</returns>
        public static string AllergyCertaintyDescriptionFromID(AllergyCertainty certainty)
        {
            string description = "Not Known";

            switch ((AllergyCertainty)certainty)
            {
                case AllergyCertainty.NotKnown:
                    description = "Not Known";
                    break;
                case AllergyCertainty.Tentative:
                    description = "Tentative";
                    break;
                case AllergyCertainty.Unlikely:
                    description = "Unlikely";
                    break;
                case AllergyCertainty.Possible:
                    description = "Possible";
                    break;
                case AllergyCertainty.Likely:
                    description = "Likely";
                    break;
                case AllergyCertainty.Certain:
                    description = "Certain";
                    break;
                case AllergyCertainty.Absolute:
                    description = "Absolute";
                    break;
            }

            return description;
        }

        /// <summary>
        /// Builds text summary for the Allergy's Certainty, Severity and Reaction
        /// </summary>
        /// <returns>A text description of the Allergy's Certainty, Severity and Reaction</returns>
        private string GetDisplayAllergyDescription()
        {
            string description = string.Empty;

            // Certainty
            if (this.Certainty != AllergyCertainty.NotKnown)
            {
                description = string.Format("{0}", Allergy.AllergyCertaintyDescriptionFromID(this.Certainty));
            }

            // Severity
            if (this.Severity != AllergySeverity.NotKnown)
            {
                description = string.Format("{0} {1}", description, Allergy.AllergySeverityDescriptionFromID(this.Severity));
            }

            // Reaction
            if (this.Reaction != AllergyReaction.NotKnown)
            {
                description = string.Format("{0} {1}", description, Allergy.AllergyReactionDescriptionFromID(this.Reaction));
            }

            // If the description is still empty then give it a text description of unknown
            if (string.IsNullOrEmpty(description))
            {
                description = Allergy.AllergyCertaintyDescriptionFromID(AllergyCertainty.NotKnown);
            }

            // Trip any leading or trailing white space and convert to lowercase with first letter in uppercase
            description = description.Trim();
            description = string.Format("{0}{1}", description.Substring(0, 1).ToUpper(), description.Substring(1).ToLower());

            return description;
        }
    }
}
