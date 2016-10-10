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
    using Enumerations;
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;


    /// <summary>
    /// Class representing a Patient
    /// </summary>
    public class Patient : Person
    {
        #region Private fields

        /// <summary>
        /// Use CHI number
        /// </summary>
        private readonly bool usersHealthBoardUsesChi;

        /// <summary>
        /// Internal ID for the local database
        /// </summary>
        private int id;

        /// <summary>
        /// The unique identifier
        /// </summary>
        private string uniqueId;

        /// <summary>
        /// The Patient's registered GP
        /// </summary>
        private string registeredGP;

        /// <summary>
        /// The Patient's preferred GP
        /// </summary>
        private string preferredGP;

        /// <summary>
        /// The Patient's list of postal addresses
        /// </summary>
        private List<PatientAddress> patientAddresses;

        /// <summary>
        /// The Patient's list of contact info
        /// </summary>
        private List<PatientContactInfo> patientContactDetails;

        /// <summary>
        /// The Allergy status for the current patient
        /// </summary>
        private Allergy.PatientAllergyState patientAllergyStatus;

        /// <summary>
        /// A timestamp when the entity was last modified
        /// </summary>
        private DateTime lastRefreshed;

        /// <summary>
        /// A value indicating the state of the patient model
        /// </summary>
        private PatientDataState state;

        /// <summary>
        /// The patient's practice id.
        /// </summary>
        private string practiceId;

        /// <summary>
        /// The patient's NHS number
        /// </summary>
        private string nhsNumber;

        /// <summary>
        /// The patient's CHI number
        /// </summary>
        private string chiNumber;

        /// <summary>
        /// The serviceID for the patient (to support querying by users with multiple practices)
        /// </summary>
        private string serviceID;

        /// <summary>
        /// The registration status
        /// </summary>
        private string registrationStatus;

        /// <summary>
        /// The practice name
        /// </summary>
        private string practiceName;
        #endregion

        /// <summary>
        /// Initializes a new instance of the <see cref="Patient" /> class
        /// </summary>
        public Patient()
        {
            this.patientAddresses = new List<PatientAddress>();
            this.patientContactDetails = new List<PatientContactInfo>();
            
        }



        /// <summary>
        /// Gets or sets the internal ID of the patient in the database
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
        /// Gets or sets the NHS number.
        /// </summary>
        /// <value>
        /// The NHS number.
        /// </value>
        public string NhsNumber
        {
            get
            {
                return this.nhsNumber;
            }

            set
            {
                this.nhsNumber = value;
                this.RaisePropertyChanged("NhsNumber");
                this.RaisePropertyChanged("PatientNumber");
            }
        }

        /// <summary>
        /// Gets or sets the chi number.
        /// </summary>
        /// <value>
        /// The chi number.
        /// </value>
        public string ChiNumber
        {
            get
            {
                return this.chiNumber;
            }

            set
            {
                this.chiNumber = value;
                this.RaisePropertyChanged("ChiNumber");
                this.RaisePropertyChanged("PatientNumber");
            }
        }

        /// <summary>
        /// Gets the person's patient number
        /// </summary>
        public string PatientNumber
        {
            get
            {
                if (this.UseNhsNumberAsPatientNumber())
                {
                    return this.NhsNumber;
                }

                return this.ChiNumber;
            }
        }

        /// <summary>
        /// Gets a qualified patient number.
        /// </summary>
        /// <returns>A qualified patient number for this instance</returns>
        public UniquePatientReference UniquePatientReference
        {
            get
            {
                return new UniquePatientReference()
                           {
                               Number = this.PatientNumber,
                               Type = this.UseNhsNumberAsPatientNumber() ? PatientNumberType.NhsNumber : PatientNumberType.Chi,
                               PracticeId = this.PracticeId
                           };
            }
        }

        /// <summary>
        /// Gets or sets the unique identifier.
        /// </summary>
        /// <value>
        /// The unique identifier.
        /// </value>
        public string UniqueId
        {
            get
            {
                return this.uniqueId;
            }

            set
            {
                this.uniqueId = value;
                this.RaisePropertyChanged("UniqueId");
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether or not this Patient Record is from an external source (e.g. EMIS)
        /// </summary>
        public bool IsExternal
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether or not this Patient Record was explicitly downloaded or had just been synchronized to the offline database
        /// </summary>
        public bool ExplicitlyDownloaded
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the Patient's registered GP
        /// </summary>
        public string RegisteredGP
        {
            get
            {
                return this.registeredGP;
            }

            set
            {
                this.registeredGP = value;
                this.RaisePropertyChanged("RegisteredGP");
            }
        }

        /// <summary>
        /// Gets or sets the Patient's preferred GP
        /// </summary>
        public string PreferredGP
        {
            get
            {
                return this.preferredGP;
            }

            set
            {
                this.preferredGP = value;
                this.RaisePropertyChanged("PreferredGP");
            }
        }
        
        /// <summary>
        /// Gets or sets the service ID of the user for which this Patient was downloaded
        /// </summary>
        public string ServiceId
        {
            get
            {
                return this.serviceID;
            }

            set
            {
                this.serviceID = value;
                this.RaisePropertyChanged("ServiceId");
            }
        }

        /// <summary>
        /// Gets or sets the Patient's list of postal addresses
        /// </summary>
        public List<PatientAddress> PatientAddresses
        {
            get
            {
                return this.patientAddresses;
            }

            set
            {
                this.patientAddresses = value;
                this.RaisePropertyChanged("PatientAddresses");
            }
        }

        /// <summary>
        /// Gets or sets the Patient's list of contact info
        /// </summary>
        public List<PatientContactInfo> PatientContactDetails
        {
            get
            {
                return this.patientContactDetails;
            }

            set
            {
                this.patientContactDetails = value;
                this.RaisePropertyChanged("PatientContactDetails");
            }
        }

        /// <summary>
        /// Gets or sets a the current patient Allergy status
        /// </summary>
        public Allergy.PatientAllergyState PatientAllergyStatus
        {
            get
            {
                return this.patientAllergyStatus;
            }

            set
            {
                this.patientAllergyStatus = value;
                this.RaisePropertyChanged("PatientAllergyStatus");
            }
        }

        /// <summary>
        /// Gets or sets the last modified timestamp
        /// </summary>
        public DateTime LastRefreshed
        {
            get
            {
                return this.lastRefreshed;
            }

            set
            {
                this.lastRefreshed = value;
                this.RaisePropertyChanged("LastRefreshed");
            }
        }

        /// <summary>
        /// Gets the patient number formatted for display
        /// </summary>
        public string DisplayPatientNumber
        {
            get
            {
                if (this.UseNhsNumberAsPatientNumber())
                {
                    return this.GetPatientNumberAsNhsNumber();
                }
                else
                {
                    return this.GetPatientNumberAsChiNumber();    
                }
            }
        }

        /// <summary>
        /// Gets the patient number label for the current for display
        /// </summary>
        public string DisplayPatientNumberLabel
        {
            get
            {
                 return this.GetPatientNumberLabel();
            }
        }
                
        /// <summary>
        /// Gets the patient's postcode
        /// </summary>
        public string DisplayPatientPostcode
        {
            get
            {
                string postCode = "Not Known";

                // Return the postcode for the first address in the patient's list of addresses
                if (this.PatientAddresses.Count > 0)
                {
                    postCode = this.patientAddresses[0].AddressPostCode;
                }

                return postCode;
            }
        }

        /// <summary>Gets or sets the practice id.</summary>
        public string PracticeId
        {
            get
            {
                return this.practiceId;
            }

            set
            {
                this.practiceId = value;
                this.RaisePropertyChanged("PracticeId");
            }
        }

        /// <summary>
        /// Gets or sets the registration status
        /// </summary>
        public string RegistrationStatus
        {
            get
            {
                return this.registrationStatus;
            }

            set
            {
                this.registrationStatus = value;
                this.RaisePropertyChanged("RegistrationStatus");
            }
        }

        /// <summary>
        /// Gets or sets the practice name
        /// </summary>
        public string PracticeName
        {
            get
            {
                return this.practiceName;
            }

            set
            {
                this.practiceName = value;
                this.RaisePropertyChanged("PracticeName");
            }
        }
        
        /// <summary>
        /// Gets or sets the external identifier.
        /// </summary>
        /// <remarks>This is the Vision 3 patient id.</remarks>
        public string ExternalId { get; set; }



        /// <summary>
        /// There are two possible data entries for a Patient Number, CHI and NHS Number. This will return true if NHS is the one to use
        /// </summary>
        /// <returns>Returns true if NHS is the one to use</returns>
        public bool UseNhsNumberAsPatientNumber()
        {
            if (string.IsNullOrEmpty(this.ChiNumber) || (this.usersHealthBoardUsesChi == false && string.IsNullOrEmpty(this.NhsNumber) == false))
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// The get patient number as NHS number.
        /// </summary>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        private string GetPatientNumberAsNhsNumber()
        {
            string nhsNumber = this.NhsNumber;

            if (nhsNumber != null)
            {
                // As Patient number is a string we cant be sure that it is already formatted 
                if (nhsNumber.Length == 10 && !nhsNumber.Contains(" "))
                {
                    // Format the patiet number as an NHS Number with the format 123 456 789
                    nhsNumber = string.Format(
                        "{0} {1} {2}",
                        nhsNumber.Substring(0, 3),
                        nhsNumber.Substring(3, 3),
                        nhsNumber.Substring(6, 4));
                }
            }
          
            return nhsNumber;
        }

        /// <summary>
        /// The get patient number as Chi number.
        /// </summary>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        private string GetPatientNumberAsChiNumber()
        {
            string chiNumber = this.ChiNumber;
            
            if (chiNumber.Length == 10 && !chiNumber.Contains(" "))
            {
                // Format the number as an CHI Number with the format 123 456 7890
                chiNumber = string.Format(
                    "{0} {1} {2}",
                    chiNumber.Substring(0, 3),
                    chiNumber.Substring(3, 3),
                    chiNumber.Substring(6, 4));
            }

            return chiNumber;
        }

        /// <summary>
        /// The get patient number label.
        /// </summary>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        private string GetPatientNumberLabel()
        {
            if (this.UseNhsNumberAsPatientNumber())
            {
                return "NHS";
            }
            else
            {
                return "CHI";
            }
        }
    }
}
