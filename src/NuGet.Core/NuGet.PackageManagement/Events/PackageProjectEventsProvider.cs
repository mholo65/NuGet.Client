// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

#if !NETSTANDARD1_3
using System.ComponentModel.Composition;
#endif

namespace NuGet.PackageManagement
{
    /// <summary>
    /// Provider for the PackageEvents singleton
    /// </summary>
#if !NETSTANDARD1_3
    [Export(typeof(IPackageProjectEventsProvider))]
#endif
    public class PackageProjectEventsProvider : IPackageProjectEventsProvider
    {
        private static PackageProjectEvents _instance;

        public PackageProjectEvents GetPackageProjectEvents()
        {
            return Instance;
        }

        internal static PackageProjectEvents Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new PackageProjectEvents();
                }

                return _instance;
            }
        }
    }
}