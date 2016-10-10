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
    /// Class representing an item of patient contact info
    /// </summary>
    public class PatientContactInfo : PersonContactInfo
    {
        /// <summary>
        /// Internal ID for the local database
        /// </summary>
        private int id;

        /// <summary>
        /// Initializes a new instance of the <see cref="PatientContactInfo" /> class
        /// </summary>
        public PatientContactInfo()
        {
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
    }
}
