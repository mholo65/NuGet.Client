using System;
using Microsoft.VisualStudio.Imaging.Interop;

namespace NuGet.PackageManagement.UI
{
    public static class PackageIconMonikers
    {
        private static readonly Guid ManifestGuid = new Guid("8F5EAE8F-9892-4CE2-826C-764BEDE6D2EC");
        private const int _prefixReservedIndicator = 1;

        public static ImageMoniker PrefixReservedIndicator => new ImageMoniker { Guid = ManifestGuid, Id = _prefixReservedIndicator };
    }
}
