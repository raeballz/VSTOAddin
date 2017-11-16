using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using VSTOWordAddin.Core.Models;

namespace VSTOWordAddin.Core.ViewModel
{
    public class RibbonViewModel
    {
        private const string NODATAOFTYPE = "Patient has no recorded data of this type";
        private Patient currentPatient;
        
        public RibbonViewModel()
        {
            this.CurrentPatient = new Patient();
        }

        public Patient CurrentPatient
        {
            get { return currentPatient; }
            set { currentPatient = value; }
        }

        public string swapTagsForData(string letter)
        {
            GetPatient();
            Tags smartTags = new Tags();

            foreach (var tag in smartTags.AllTags)
            {
                letter = letter.Replace(tag, RaplaceTag(tag));
            }

            return letter;
        }

        private string RaplaceTag(string tag)
        {
            switch (tag)
            {
                case Tags.FORENAME:
                    {
                        return CurrentPatient.GivenName;
                    }
                case Tags.SURNAME:
                    {
                        return CurrentPatient.FamilyName;
                    }
                case Tags.MIDDLENAMES:
                    {
                        string middleNames = string.Empty;
                        foreach (string mName in CurrentPatient.MiddleNames)
                        {
                            middleNames += $"{mName} ";
                        }
                        return middleNames;                        
                    }
                case Tags.AGE:
                    {
                        return CurrentPatient.Age.ToString();
                    }
                case Tags.DOB:
                    {
                        return CurrentPatient.DateOfBirth.Date.ToString();
                    }
                case Tags.MOBILENO:
                    {
                        string mobileNums = NODATAOFTYPE; 

                        foreach (var detail in CurrentPatient.PatientContactDetails)
                        {
                            if (detail.ContactType == PersonContactInfo.ContactInfoType.PhoneNumber)
                            {
                                if (detail.ContactDetails.Substring(0, 2).Equals("07"))
                                {
                                    if (mobileNums.Equals(NODATAOFTYPE))
                                    {
                                        mobileNums = string.Empty;
                                    }

                                    if (!string.IsNullOrWhiteSpace(mobileNums))
                                    {
                                        mobileNums += ", ";
                                    }
                                    mobileNums += detail.ContactDetails;
                                }
                            }
                        }
                        return mobileNums;
                    }
                case Tags.PHONENO:
                    {
                        string phoneNums = NODATAOFTYPE; 

                        foreach (var detail in CurrentPatient.PatientContactDetails)
                        {
                            if (detail.ContactType == PersonContactInfo.ContactInfoType.PhoneNumber)
                            {
                                if (detail.ContactDetails.Substring(0, 2).Equals("07"))
                                {
                                    if (phoneNums.Equals(NODATAOFTYPE))
                                    {
                                        phoneNums = string.Empty;
                                    }

                                    if (!string.IsNullOrWhiteSpace(phoneNums))
                                    {
                                        phoneNums += ", ";
                                    }
                                    phoneNums += detail.ContactDetails;
                                }
                            }
                        }
                        return phoneNums; ;
                    }
                case Tags.EMAIL:
                    {
                        string emails = NODATAOFTYPE; 
                        foreach (var detail in CurrentPatient.PatientContactDetails)
                        {
                            if (detail.ContactType == PersonContactInfo.ContactInfoType.EmailAddress)
                            {
                                if (emails.Equals(NODATAOFTYPE))
                                {
                                    emails = string.Empty;
                                }

                                if (!string.IsNullOrWhiteSpace(emails))
                                {
                                    emails += ", ";
                                }
                                emails += detail.ContactDetails;
                            }
                        }
                        return emails;
                    }
                case Tags.POSTCODE:
                    {
                        return CurrentPatient.DisplayPatientPostcode;
                    }
                case Tags.ADDRESS:
                    {
                        string addressText = NODATAOFTYPE;
                        if (CurrentPatient.PatientAddresses.Count > 0)
                        {
                            addressText = string.Empty;
                            addressText += AddValidAddressLine(CurrentPatient.PatientAddresses[0].AddressLine1);
                            addressText += AddValidAddressLine(CurrentPatient.PatientAddresses[0].AddressLine2);
                            addressText += AddValidAddressLine(CurrentPatient.PatientAddresses[0].AddressLine3);
                            addressText += AddValidAddressLine(CurrentPatient.PatientAddresses[0].AddressTownCity);
                            addressText += AddValidAddressLine(CurrentPatient.PatientAddresses[0].AddressCounty);
                            addressText += AddValidAddressLine(CurrentPatient.PatientAddresses[0].AddressCountry);
                            addressText += AddValidAddressLine(CurrentPatient.PatientAddresses[0].AddressPostCode);
                        }
                        return addressText;
                    }
                default:
                    {
                        return "Tag Not Found";
                    }
            }
        }

        private string AddValidAddressLine(string text)
        {
            return !string.IsNullOrWhiteSpace(text) ? text +"\n" : string.Empty;
        }

        private void GetPatient()
        {
            SQLiteConnection con = new SQLiteConnection(@"Data Source=E:\\DataBases\\VSTODB.db;Version=3;New=True;Compress=True;");
            con.Open();
            
            var CMD = new SQLiteCommand("SELECT * FROM patient", con);

            SQLiteDataReader reader = CMD.ExecuteReader();

            while (reader.Read())
            {
                this.CurrentPatient = JsonConvert.DeserializeObject<Patient>(Convert.ToString(reader["SerialisedPatient"]));
            }
        }
    }
}
