// -------------------------------------------------------------------------------------------------------------------------------
// <copyright file="DIRegistrationModule.cs" company="Exul aka Michael Kokorin">
//     Copyright (c) Exul aka Michael Kokorin. All rights reserved.
// </copyright>
// <author>
//     Exul aka Michael Kokorin (michael.kokorin@hotmail.com)
// </author>
// -------------------------------------------------------------------------------------------------------------------------------

namespace Task4Console
{
    #region Usings

    using System;

    using ExulLibrary.IoC;

    #endregion

    /// <summary>
    ///     Provides binding for IoC-container.
    /// </summary>
    internal sealed class DIRegistrationModule : IDIRegistrationModule
    {
        #region Interfaces

        #region IDIRegistrationModule

        /// <summary>
        ///     Initializes dependencies for the specified container.
        /// </summary>
        /// <param name="container">
        ///     The IoC container.
        /// </param>
        /// <exception cref="ArgumentNullException">
        ///     <paramref name="container"/> is <see langword="null"/>.
        /// </exception>
        public void Initialize(DIContainer container)
        {
        }

        #endregion

        #endregion
    }
}