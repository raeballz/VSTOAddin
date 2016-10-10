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

    /// <summary>
    /// Class representing a patient's postal address
    /// </summary>
    public class PatientAddress : PostalAddress
    {
        /// <summary>
        /// Internal ID for the local database
        /// </summary>
        private int id;

        /// <summary>
        /// The type of post address
        /// </summary>
        private string addressType;

        /// <summary>
        /// Initializes a new instance of the <see cref="PatientAddress" /> class
        /// </summary>
        public PatientAddress()
        {
            this.addressType = string.Empty;
        }

        /// <summary>
        /// Gets or sets the internal ID of the address in the database
        /// </summary>
        public int ID
        {
            get
            {
                return this.id;
            }

            set
            {
                this.id = value;
                this.RaisePropertyChanged("ID");
            }
        }

        /// <summary>
        /// Gets or sets the patient id.
        /// </summary>
        public int PatientId { get; set; }

        /// <summary>
        /// Gets or sets the address type
        /// </summary>
        public string AddressType
        { 
            get
            {
                return this.addressType;
            }

            set
            {
                this.addressType = value;
                this.RaisePropertyChanged("AddressType");
            }
        }
    }
}
