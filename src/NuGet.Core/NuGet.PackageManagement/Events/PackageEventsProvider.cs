// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

#if !NETSTANDARD1_6
using System.ComponentModel.Composition;
#endif

namespace NuGet.ProjectManagement
{
    /// <summary>
    /// Provider for the PackageEvents singleton
    /// </summary>
#if !NETSTANDARD1_6
    [Export(typeof(IPackageEventsProvider))]
#endif
    public class PackageEventsProvider : IPackageEventsProvider
    {
        private static PackageEvents _instance;

        public PackageEvents GetPackageEvents()
        {
            return Instance;
        }

        internal static PackageEvents Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new PackageEvents();
                }

                return _instance;
            }
        }
    }
}
