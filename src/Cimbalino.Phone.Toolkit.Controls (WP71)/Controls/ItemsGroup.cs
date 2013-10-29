﻿// ****************************************************************************
// <copyright file="ItemsGroup.cs" company="Pedro Lamas">
// Copyright © Pedro Lamas 2011
// </copyright>
// ****************************************************************************
// <author>Pedro Lamas</author>
// <email>pedrolamas@gmail.com</email>
// <date>09-05-2012</date>
// <project>Cimbalino.Phone.Toolkit.Controls</project>
// <web>http://www.pedrolamas.com</web>
// <license>
// See license.txt in this solution or http://www.pedrolamas.com/license_MIT.txt
// </license>
// ****************************************************************************

using System.Collections.Generic;

namespace Cimbalino.Phone.Toolkit.Controls
{
    /// <summary>
    /// Represents a group for a collections of items.
    /// </summary>
    /// <typeparam name="T">The items collection type.</typeparam>
    public class ItemsGroup<T> : List<T>
    {
        #region Properties

        /// <summary>
        /// Gets the group name.
        /// </summary>
        /// <value>The group name.</value>
        public string Name { get; private set; }

        #endregion

        /// <summary>
        /// Initializes a new instance of the <see cref="ItemsGroup{T}" /> class.
        /// </summary>
        /// <param name="name">The group name.</param>
        /// <param name="items">The group items list.</param>
        public ItemsGroup(string name, IEnumerable<T> items)
            : base(items)
        {
            Name = name;
        }
    }
}