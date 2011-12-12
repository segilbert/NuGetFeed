﻿using System.Linq;

using NuGetFeed.Infrastructure.PackageSources;

namespace NuGetFeed.NuGetService
{
    public partial class FeedContext_x0060_1 : IGalleryFeedContext
    {
        public IQueryable<V1FeedPackage> AllPackages
        {
            get
            {
                return Packages;
            }
        }
    }
}