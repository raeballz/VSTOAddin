//------------------------------------------------------------------
//
// Copyright (c) 2012 - 2014 Adaptive Apps Ltd. All rights reserved.
// 
// MvvmCross is licensed using Microsoft Public License (Ms-PL)
// Copyright (c) Cirrious Ltd. http://www.cirrious.com
//
//------------------------------------------------------------------

namespace PatientHub.Framework.Core.Interfaces
{
    /// <summary>
    /// Interface for items that are person records.
    /// </summary>
    public interface IPersonRecord
    {
        /// <summary>
        /// Gets or sets the person's title
        /// </summary>
        string Title { get; set; }

        /// <summary>
        /// Gets or sets the person's family name
        /// </summary>
        string FamilyName { get; set; }

        /// <summary>
        /// Gets or sets the person's given name
        /// </summary>
        string GivenName { get; set; }
    }
}
