using Apache.Ignite.Core.Cache.Store;
using Apache.Ignite.Core.Common;
using DotNetIgniteQueryTestApp.Interface;
using IgnitePersistenceApp.ConstructionApp.CacheStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IgnitePersistenceApp.ConstructionApp.CacheStoreFactory
{
    public class ConstructionTenantCacheStoreFactory : IFactory<ICacheStore<string, IConstructionCacheStore>>
    {
        public ConstructionTenantCacheStoreFactory()
        {
        }

        ICacheStore<string, IConstructionCacheStore> IFactory<ICacheStore<string, IConstructionCacheStore>>.CreateInstance()
        {
            return new ConstructionTenantCacheStore();
        }
    }
}
