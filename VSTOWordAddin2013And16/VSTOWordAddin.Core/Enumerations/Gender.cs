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
    /// <summary>
    /// An list of genders that a person can have
    /// </summary>
    public enum Gender : int
    {
        // TODO: Determine what the full list of standard classifications should be

        /// <summary>
        /// Gender is not known
        /// </summary>
        NotKnown = -1,

        /// <summary>
        /// Gender is male
        /// </summary>
        Male = 0,

        /// <summary>
        /// gender is female
        /// </summary>
        Female = 1
    }
}