//------------------------------------------------------------------
//
// Copyright (c) 2015 INPS Ltd. 
// All rights reserved.
// 
// MvvmCross is licensed using Microsoft Public License (Ms-PL)
// Copyright (c) Cirrious Ltd. http://www.cirrious.com
//
//------------------------------------------------------------------

namespace INPS.Platform.Core.Utilities
{
    using System;
    using System.Linq.Expressions;
    using System.Reflection;

    /// <summary>
    /// Reflection support functions.
    /// </summary>
    public static class ReflectionSupport
    {
        /// <summary>
        /// Gets the name of the property.
        /// </summary>
        /// <typeparam name="T">The Type.</typeparam>
        /// <param name="propertyExpression">The property expression.</param>
        /// <returns>The property name.</returns>
        /// <exception cref="System.ArgumentNullException">Raised where <c>propertyExpression</c> is null.</exception>
        /// <exception cref="System.ArgumentException">
        /// Invalid argument.
        /// or 
        /// Argument is not a property.
        /// </exception>
        public static string GetPropertyName<T>(Expression<Func<T>> propertyExpression)
        {
            if (propertyExpression == null)
            {
                throw new ArgumentNullException("propertyExpression");
            }

            var body = propertyExpression.Body as MemberExpression;

            if (body == null)
            {
                throw new ArgumentException("Invalid argument", "propertyExpression");
            }

            var property = body.Member as PropertyInfo;

            if (property == null)
            {
                throw new ArgumentException("Argument is not a property", "propertyExpression");
            }

            return property.Name;
        }
    }
}
