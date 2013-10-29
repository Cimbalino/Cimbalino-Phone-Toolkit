﻿// ****************************************************************************
// <copyright file="CameraCaptureService.cs" company="Pedro Lamas">
// Copyright © Pedro Lamas 2011
// </copyright>
// ****************************************************************************
// <author>Pedro Lamas</author>
// <email>pedrolamas@gmail.com</email>
// <date>21-11-2011</date>
// <project>Cimbalino.Phone.Toolkit.Camera</project>
// <web>http://www.pedrolamas.com</web>
// <license>
// See license.txt in this solution or http://www.pedrolamas.com/license_MIT.txt
// </license>
// ****************************************************************************

using System;
using System.Threading.Tasks;
using Microsoft.Phone.Tasks;

namespace Cimbalino.Phone.Toolkit.Services
{
    /// <summary>
    /// Represents an implementation of the <see cref="ICameraCaptureService"/>.
    /// </summary>
    public class CameraCaptureService : ICameraCaptureService
    {
        /// <summary>
        /// Shows the camera application.
        /// </summary>
        /// <param name="resultAction">The <see cref="Action{PhotoResult}"/> to be called once the operation is finished.</param>
        public void Show(Action<PhotoResult> resultAction)
        {
            new ChooserHandler<PhotoResult>(new CameraCaptureTask(), resultAction)
                .Show();
        }

        /// <summary>
        /// Shows the camera application.
        /// </summary>
        /// <returns>The <see cref="Task"/> object representing the asynchronous operation.</returns>
        public Task<PhotoResult> ShowAsync()
        {
            return new ChooserHandler<PhotoResult>(new CameraCaptureTask())
                .ShowAsync();
        }
    }
}