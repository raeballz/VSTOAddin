//------------------------------------------------------------------
//
// Copyright (c) 2012 - 2014 Adaptive Apps Ltd. All rights reserved.
// 
// MvvmCross is licensed using Microsoft Public License (Ms-PL)
// Copyright (c) Cirrious Ltd. http://www.cirrious.com
//
//------------------------------------------------------------------

namespace PatientHub.Framework.Core.Models
{
    using Helpers;
    using Interfaces;
    #region Using statements

    using System;
    using System.ComponentModel;

    #endregion Using statements

    /// <summary>
    /// Class representing a Person
    /// </summary>
    public class Person : IPersonRecord
    {
        #region Private fields

        /// <summary>
        /// The person's title
        /// </summary>
        private string personTitle;

        /// <summary>
        /// The person's gender
        /// </summary>
        private Gender gender;

        /// <summary>
        /// The person's Family Name
        /// </summary>
        private string familyName;

        /// <summary>
        /// The Person's Given name
        /// </summary>
        private string givenName;

        /// <summary>
        /// The first name by which the Person is known as
        /// </summary>
        private string knownAsName;

        /// <summary>
        /// The Person's Date of Birth
        /// </summary>
        private DateTime dateOfBirth;

        /// <summary>
        /// The Person's Date of Death
        /// </summary>
        private DateTime dateOfDeath;

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Person" /> class
        /// </summary>
        public Person()
        {
            this.personTitle = string.Empty;
            this.gender = Gender.NotKnown;
            this.familyName = string.Empty;
            this.givenName = string.Empty;
            this.knownAsName = string.Empty;
            this.dateOfBirth = new DateTime(0);
            this.dateOfDeath = new DateTime(0);
        }

        #endregion Constructors

        #region Events

        /// <summary>
        /// An event to notify when a property has changed
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        #endregion Events

        #region Properties

        /// <summary>
        /// Gets or sets the person's title
        /// </summary>
        public string Title
        {
            get
            {
                return this.personTitle;
            }

            set
            {
                this.personTitle = value;
                this.RaisePropertyChanged("Title");
            }
        }

        /// <summary>
        /// Gets or sets the person's gender
        /// </summary>
        public Gender PersonGender
        {
            get
            {
                return this.gender;
            }

            set
            {
                this.gender = value;
                this.RaisePropertyChanged("PersonGender");
            }
        }

        /// <summary>
        /// Gets or sets the person's family name
        /// </summary>
        public string FamilyName
        {
            get
            {
                return this.familyName;
            }

            set
            {
                this.familyName = value;
                this.RaisePropertyChanged("FamilyName");
            }
        }

        /// <summary>
        /// Gets or sets the person's given name
        /// </summary>
        public string GivenName
        {
            get
            {
                return this.givenName;
            }

            set
            {
                this.givenName = value;
                this.RaisePropertyChanged("GivenName");
            }
        }



        /// <summary>
        /// Gets or sets the name by which the person is known as
        /// </summary>
        public string KnownAsName
        {
            get
            {
                return this.knownAsName;
            }

            set
            {
                this.knownAsName = value;
                this.RaisePropertyChanged("KnownAsName");
            }
        }

        /// <summary>
        /// Gets or sets the person's date of birth
        /// </summary>
        public DateTime DateOfBirth
        {
            get
            {
                return this.dateOfBirth;
            }
            
            set
            {
                this.dateOfBirth = value;
                this.RaisePropertyChanged("DateOfBirth");
            }
        }

        /// <summary>
        /// Gets or sets the person's date of death
        /// </summary>
        public DateTime DateOfDeath
        {
            get
            {
                return this.dateOfDeath;
            }

            set
            {
                this.dateOfDeath = value;
                this.RaisePropertyChanged("DateOfDeath");
            }
        }

        /// <summary>
        /// Gets the date of birth and age formatted for display.
        /// </summary>
        public string DisplayDateOfBirth
        {
            get
            {
                if (this.DateOfBirth == DateTime.MinValue)
                {
                    return null;
                }

                return string.Format("{0} ({1})", this.DateOfBirth.ToString("dd-MMM-yyyy"), this.DisplayAge);
            }
        }

        /// <summary>
        /// Gets the age of the person
        /// </summary>
        public int Age
        {
            get
            {
                var today = DateTime.Today;
                var retVal = today.Year - this.dateOfBirth.Year;
                if (this.dateOfBirth > today.AddYears(-retVal))
                {
                    retVal--;
                }

                return retVal;
            }
        }

        /// <summary>
        /// Gets the date of birth and age formatted for display.
        /// </summary>
        public string DisplayAge
        {
            get
            {
                // TODO: This needs to apply the CUI guidance for foramtting ages when the patient is less than 1 year old: hours, days or months 
                return string.Format("{0}y", this.Age);
            }
        }

        /// <summary>
        /// Gets the gender formatted for display.
        /// </summary>
        public string DisplayPersonGender
        {
            get
            {
                return GenderHelper.GenderValueToGenderString(this.PersonGender);
            }
        }

        #endregion Properties


        #region Protected methods

        /// <summary>
        /// Raises an event when a property changes
        /// </summary>
        /// <param name="propertyName">The property changing</param>
        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if (propertyChanged != null)
            {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion Protected methods
    }
}
