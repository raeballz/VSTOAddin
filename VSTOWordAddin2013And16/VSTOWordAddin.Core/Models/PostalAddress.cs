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
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.ComponentModel;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Class representing a postal address
    /// </summary>
    public class PostalAddress : INotifyPropertyChanged
    {
        /// <summary>
        /// First line of the address
        /// </summary>
        private string addressLine1;

        /// <summary>
        /// Second line of the address
        /// </summary>
        private string addressLine2;

        /// <summary>
        /// Third line line of the address
        /// </summary>
        private string addressLine3;

        /// <summary>
        /// Address town or city
        /// </summary>
        private string addressTownCity;

        /// <summary>
        /// Address county
        /// </summary>
        private string addressCounty;

        /// <summary>
        /// Address county
        /// </summary>
        private string addressCountry;

        /// <summary>
        /// Address postal code
        /// </summary>
        private string addressPostCode;

        /// <summary>
        /// Initializes a new instance of the <see cref="PostalAddress" /> class
        /// </summary>
        public PostalAddress()
        {
            this.addressLine1 = string.Empty;
            this.addressLine2 = string.Empty;
            this.addressLine3 = string.Empty;
            this.addressTownCity = string.Empty;
            this.addressCounty = string.Empty;
            this.addressCountry = string.Empty;
            this.addressPostCode = string.Empty;
        }

        /// <summary>
        /// An event to notify when a property has changed
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Gets or sets the First line of the address
        /// </summary>
        public string AddressLine1
        { 
            get
            {
                return this.addressLine1;
            }

            set
            {
                this.addressLine1 = value;
                this.RaisePropertyChanged("AddressLine1");
            }
        }

        /// <summary>
        /// Gets or sets the Second line of the address
        /// </summary>
        public string AddressLine2
        { 
            get
            {
                return this.addressLine2;
            }

            set
            {
                this.addressLine2 = value;
                this.RaisePropertyChanged("AddressLine2");
            }
        }

        /// <summary>
        /// Gets or sets the Third line line of the address
        /// </summary>
        public string AddressLine3
        { 
            get
            {
                return this.addressLine3;
            }

            set
            {
                this.addressLine3 = value;
                this.RaisePropertyChanged("AddressLine3");
            }
        }

        /// <summary>
        /// Gets or sets the Address town or city
        /// </summary>
        public string AddressTownCity
        { 
            get
            {
                return this.addressTownCity;
            }

            set
            {
                this.addressTownCity = value;
                this.RaisePropertyChanged("AddressTownCity");
            }
        }

        /// <summary>
        /// Gets or sets the Address county
        /// </summary>
        public string AddressCounty
        { 
            get
            {
                return this.addressCounty;
            }

            set
            {
                this.addressCounty = value;
               this.RaisePropertyChanged("AddressCounty");
            }
        }

        /// <summary>
        /// Gets or sets the Address country
        /// </summary>
        public string AddressCountry
        {
            get
            {
                return this.addressCountry;
            }

            set
            {
                this.addressCountry = value;
                this.RaisePropertyChanged("AddressCountry");
            }
        }

        /// <summary>
        /// Gets or sets the Address postal code
        /// </summary>
        public string AddressPostCode
        { 
            get
            {
                return this.addressPostCode;
            }

            set
            {
                this.addressPostCode = value;
                this.RaisePropertyChanged("AddressPostCode");
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
