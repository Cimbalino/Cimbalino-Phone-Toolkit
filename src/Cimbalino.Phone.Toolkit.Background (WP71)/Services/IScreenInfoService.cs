﻿// ****************************************************************************
// <copyright file="IScreenInfoService.cs" company="Pedro Lamas">
// Copyright © Pedro Lamas 2012
// </copyright>
// ****************************************************************************
// <author>Pedro Lamas</author>
// <email>pedrolamas@gmail.com</email>
// <date>30-11-2012</date>
// <project>Cimbalino.Phone.Toolkit.Background</project>
// <web>http://www.pedrolamas.com</web>
// <license>
// See license.txt in this solution or http://www.pedrolamas.com/license_MIT.txt
// </license>
// ****************************************************************************

using System.Windows;

namespace Cimbalino.Phone.Toolkit.Services
{
    /// <summary>
    /// Represents a service capable of retrieving device resolution information.
    /// </summary>
    public interface IScreenInfoService
    {
        /// <summary>
        /// Gets a value indicating the device scale factor.
        /// </summary>
        /// <value>The device scale factor.</value>
        int ScaleFactor { get; }

        /// <summary>
        /// Gets the device resolution.
        /// </summary>
        /// <value>The device resolution.</value>
        ScreenInfoServiceResolution Resolution { get; }

        /// <summary>
        /// Gets the device aspect ratio.
        /// </summary>
        /// <value>The device aspect ratio.</value>
        ScreenInfoServiceAspectRatio AspectRatio { get; }

        /// <summary>
        /// Gets the device screen size.
        /// </summary>
        /// <value>The device screen size.</value>
        Size Size { get; }
    }
}