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
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq.Expressions;
    using System.Runtime.CompilerServices;
    using INPS.Platform.Core.Utilities;

    /// <summary>
    /// Observable Object implements IObservable Object interface.
    /// </summary>
    public class ObservableObject : IObservableObject
    {
        #region Events

        /// <summary>
        /// Occurs when a property value changes.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        #region Public Methods

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
        public bool SetProperty<T>(ref T storage, T value, Expression<Func<T>> propertyExpression)
        {
            if (EqualityComparer<T>.Default.Equals(storage, value))
            {
                return false;
            }

            storage = value;

            RaisePropertyChanged(propertyExpression);

            return true;
        }

        /// <summary>
        /// Raises the property changed event.
        /// </summary>
        /// <param name="propertyName">Name of the property.</param>
        public void RaisePropertyChanged([CallerMemberName] string propertyName = "")
        {
            RaisePropertyChanged(new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Raises the property changed event.
        /// </summary>
        /// <typeparam name="T">The Type.</typeparam>
        /// <param name="propertyExpression">The property expression.</param>
        public void RaisePropertyChanged<T>(Expression<Func<T>> propertyExpression)
        {
            var propertyName = ReflectionSupport.GetPropertyName(propertyExpression);
            RaisePropertyChanged(propertyName);
        }

        #endregion

        #region Protected Methods

        /// <summary>
        /// Raises the property changed.
        /// </summary>
        /// <param name="args">The <see cref="PropertyChangedEventArgs"/> instance containing the event data.</param>
        protected void RaisePropertyChanged(PropertyChangedEventArgs args)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, args);
            }
        }

        #endregion
    }
}