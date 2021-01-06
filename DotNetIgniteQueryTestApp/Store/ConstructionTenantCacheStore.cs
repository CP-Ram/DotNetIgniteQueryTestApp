using Apache.Ignite.Core.Cache.Store;
using DotNetIgniteQueryTestApp.Interface;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace IgnitePersistenceApp.ConstructionApp.CacheStore
{
    public class ConstructionTenantCacheStore : ICacheStore<string, IConstructionCacheStore>
    {
        public ConstructionTenantCacheStore()
        {

        }

        public void Delete(string key)
        {
            throw new NotImplementedException();
        }

        public void DeleteAll(IEnumerable<string> keys)
        {
            throw new NotImplementedException();
        }

        public IConstructionCacheStore Load(string key)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<KeyValuePair<string, IConstructionCacheStore>> LoadAll(IEnumerable<string> keys)
        {
            throw new NotImplementedException();
        }

        public void LoadCache(Action<string, IConstructionCacheStore> act, params object[] args)
        {
            throw new NotImplementedException();
        }

        public void SessionEnd(bool commit)
        {
            throw new NotImplementedException();
        }

        public void Write(string key, IConstructionCacheStore val)
        {
            throw new NotImplementedException();
        }

        public void WriteAll(IEnumerable<KeyValuePair<string, IConstructionCacheStore>> entries)
        {
            throw new NotImplementedException();
        }
    }
}