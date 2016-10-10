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

    using VSTOWordAddin.Core.Enumerations;

    /// <summary>
    /// A patient's number could originate from the NHS numbering system or CHI. To fully identify a patient number you need to know its type.
    /// Some Patients are registered in multiple practices, they will have the same <see cref="Type"/> and <see cref="Number"/> so the PracticeId is also needed for those
    /// </summary>
    public struct UniquePatientReference
    {
        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>
        /// The type.
        /// </value>
        public PatientNumberType Type { get; set; }

        /// <summary>
        /// Gets or sets the number.
        /// </summary>
        /// <value>
        /// The number.
        /// </value>
        public string Number { get; set; }

        /// <summary>
        /// Gets or sets the practice id.
        /// </summary>
        /// <value>
        /// The practice id.
        /// </value>
        public string PracticeId { get; set; }

        /// <summary>
        /// From a string.
        /// </summary>
        /// <param name="uniquePatientReference">The qualified patient number.</param>
        /// <returns>A UniquePatientReference</returns>
        public static UniquePatientReference FromString(string uniquePatientReference)
        {
            string[] parts = uniquePatientReference.Split('-');

            UniquePatientReference reference = new UniquePatientReference();

            reference.Type = (PatientNumberType)Enum.Parse(typeof(PatientNumberType), parts[0]);
            reference.Number = parts[1];

            if (parts.Length == 3)
            {
                reference.PracticeId = parts[2];
            }

            return reference;
        }

        /// <summary>
        /// Implements the operator ==.
        /// </summary>
        /// <param name="qpn1">The QPN1.</param>
        /// <param name="qpn2">The QPN2.</param>
        /// <returns>
        /// The result of the operator.
        /// </returns>
        public static bool operator ==(UniquePatientReference qpn1, UniquePatientReference qpn2)
        {
            return qpn1.Equals(qpn2);
        }

        /// <summary>
        /// Implements the operator !=.
        /// </summary>
        /// <param name="qpn1">The QPN1.</param>
        /// <param name="qpn2">The QPN2.</param>
        /// <returns>
        /// The result of the operator.
        /// </returns>
        public static bool operator !=(UniquePatientReference qpn1, UniquePatientReference qpn2)
        {
            return !qpn1.Equals(qpn2);
        }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return string.Format("{0}-{1}{2}", Enum.GetName(typeof(PatientNumberType), this.Type), this.Number, this.PracticeId != null ? string.Format("-{0}", this.PracticeId) : null);
        }

        /// <summary>
        /// Returns a mostly empty Patient instance. Just relevant Number is set
        /// </summary>
        /// <returns>A Patient</returns>
        public Patient AsPatient()
        {
            var p = new Patient();

            if (this.Type == PatientNumberType.NhsNumber)
            {
                p.NhsNumber = this.Number;
            }
            else
            {
                p.ChiNumber = this.Number;
            }

            p.PracticeId = this.PracticeId;

            return p;
        }
    }
}
