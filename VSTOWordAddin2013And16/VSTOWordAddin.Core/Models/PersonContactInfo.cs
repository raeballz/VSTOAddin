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
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.ComponentModel;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Class representing contact information for a person
    /// </summary>
    public class PersonContactInfo 
    {
        /// <summary>
        /// Contact type
        /// </summary>
        private ContactInfoType contactType;

        /// <summary>
        /// Contact description
        /// </summary>
        private string contactDescription;

        /// <summary>
        /// Contact details
        /// </summary>
        private string contactDetails;

        /// <summary>
        /// Initializes a new instance of the <see cref="PersonContactInfo" /> class
        /// </summary>
        public PersonContactInfo()
        {
            this.contactDescription = string.Empty;
            this.contactDetails = string.Empty;
        }

        /// <summary>
        /// An event to notify when a property has changed
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Defines different contac info types
        /// </summary>
        public enum ContactInfoType
        {
            /// <summary>
            /// An other type of unknown contact info 
            /// </summary>
            Other = 0,

            /// <summary>
            /// A phone number
            /// </summary>
            PhoneNumber = 1,

            /// <summary>
            /// An email address
            /// </summary>
            EmailAddress = 2
        }

        /// <summary>
        /// Gets or sets the Contact description
        /// </summary>
        public ContactInfoType ContactType
        {
            get
            {
                return this.contactType;
            }

            set
            {
                this.contactType = value;
                this.RaisePropertyChanged("ContactType");
            }
        }

        /// <summary>
        /// Gets or sets the Contact description
        /// </summary>
        public string ContactDescription
        { 
            get
            {
                return this.contactDescription;
            }

            set
            {
                this.contactDescription = value;
                this.RaisePropertyChanged("ContactDescription");
            }
        }

        /// <summary>
        /// Gets or sets the Contact details
        /// </summary>
        public string ContactDetails
        { 
            get
            {
                return this.contactDetails;
            }

            set
            {
                this.contactDetails = value;
                this.RaisePropertyChanged("ContactDetail");
            }
        }

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
    }
}
