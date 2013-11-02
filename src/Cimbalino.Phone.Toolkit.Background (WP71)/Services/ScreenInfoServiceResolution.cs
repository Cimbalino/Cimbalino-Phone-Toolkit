﻿// ****************************************************************************
// <copyright file="ScreenInfoServiceResolution.cs" company="Pedro Lamas">
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

namespace Cimbalino.Phone.Toolkit.Services
{
    /// <summary>
    /// Describes the device resolution.
    /// </summary>
    public enum ScreenInfoServiceResolution
    {
        /// <summary>
        /// The device has an unknown resolution.
        /// </summary>
        Unknown = 0,

        /// <summary>
        /// The device has a WVGA (480x800) resolution.
        /// </summary>
        WVGA = 100,

        /// <summary>
        /// The device has a HD 720p (720x1280) resolution.
        /// </summary>
        HD720p = 150,

        /// <summary>
        /// The device has a WXGA (768x1280) resolution.
        /// </summary>
        WXGA = 160,

        /// <summary>
        /// The device has a HD 1080p (1080x1920) resolution.
        /// </summary>
        HD1080p = 225
    }
}