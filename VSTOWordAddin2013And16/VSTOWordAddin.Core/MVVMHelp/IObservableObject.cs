//------------------------------------------------------------------
//
// Copyright (c) 2015 INPS Ltd. 
// All rights reserved.
// 
// MvvmCross is licensed using Microsoft Public License (Ms-PL)
// Copyright (c) Cirrious Ltd. http://www.cirrious.com
//
//------------------------------------------------------------------

namespace INPS.Platform.Core.MVVM.Support
{
    using System;
    using System.ComponentModel;
    using System.Linq.Expressions;
    using System.Runtime.CompilerServices;

    /// <summary>
    /// Interface definition for an Observable Object.
    /// </summary>
    public interface IObservableObject : INotifyPropertyChanged
    {
        /// <summary>
        /// Sets the property.
        /// </summary>
        /// <typeparam name="T">Calling member Type.</typeparam>
        /// <param name="storage">The storage.</param>
        /// <param name="value">The value.</param>
        /// <param name="propertyExpression">The property expression.</param>
        /// <returns>
        /// If a value was changed then <c>true</c>, else <c>false</c>.
        /// </returns>
        bool SetProperty<T>(ref T storage, T value, Expression<Func<T>> propertyExpression);

        /// <summary>
        /// Raises the property changed event.
        /// </summary>
        /// <param name="propertyName">Name of the property.</param>
        void RaisePropertyChanged([CallerMemberName] string propertyName = "");

        /// <summary>
        /// Raises the property changed event.
        /// </summary>
        /// <typeparam name="T">The Type.</typeparam>
        /// <param name="propertyExpression">The property expression.</param>
        void RaisePropertyChanged<T>(Expression<Func<T>> propertyExpression);
    }
}
