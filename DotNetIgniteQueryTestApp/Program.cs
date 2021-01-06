using Apache.Ignite.Core;
using Apache.Ignite.Core.Cache;
using Apache.Ignite.Core.Cache.Configuration;
using Apache.Ignite.Core.Cache.Eviction;
using DotNetIgniteQueryTestApp.Interface;
using DotNetIgniteQueryTestApp.Models;
using IgnitePersistenceApp.ConstructionApp.CacheStoreFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetIgniteQueryTestApp
{
    struct QueryEntityIndexFields
    {
        public string[] PrimaryKeys;
        public Type ModelType;
        //public string QueryIndexType;
    }
    class Program
    {
        public static IIgnite Ignite;

        private static readonly string[] EntityId = new[] { "EntityId" };
        private static readonly string[] SGIdEntityId = new[] { "SecurityGroupId", "SGEntityId" };

        private static readonly QueryEntityIndexFields[] TasksModels = new[] {            //Tasks
            new QueryEntityIndexFields(){PrimaryKeys=EntityId, ModelType=  typeof(Tasks_Tasks)}
        };

        private static readonly QueryEntityIndexFields[] securityModels = new[] {            //Create For Security
            new QueryEntityIndexFields(){PrimaryKeys = SGIdEntityId, ModelType=  typeof(SecurityGroups) }
        };

        private static async Task<List<QueryEntity>> GetQueryEntitiesBasedOnCapability(QueryEntityIndexFields[] queryEntityIndexFieldsList)
        {
            List<QueryEntity> queryList = new List<QueryEntity>();
            foreach (var modelObject in queryEntityIndexFieldsList)
            {
                var query = new QueryEntity(typeof(string), modelObject.ModelType)
                {
                    Indexes = new List<QueryIndex>(modelObject.PrimaryKeys.Count() + 1)
                        {
                            new QueryIndex(true,0,modelObject.PrimaryKeys)
                        }
                };
                queryList.Add(query);
            }
            return queryList;
        }

        static void Main(string[] args)
        {
            bool cacheMetrics = false;
            int backupNodes = 0;
            List<QueryEntity> queryList = null;
            string cacheName = null;
            string groupName = null;
            for (int i= 0;i < 2; i++) {
                if (i == 0)
                {
                    queryList = GetQueryEntitiesBasedOnCapability(TasksModels).GetAwaiter().GetResult();
                    cacheName = "F2DEDF6E-393E-42BC-9BB3-E835A1063B30_6EFB69B0-269F-4F92-98CF-24BC0D34BA98_TASKS";
                    groupName = "F2DEDF6E-393E-42BC-9BB3-E835A1063B30_6EFB69B0-269F-4F92-98CF-24BC0D34BA98";
                }
                else
                {
                    queryList = GetQueryEntitiesBasedOnCapability(securityModels).GetAwaiter().GetResult();
                    cacheName = "F2DEDF6E-393E-42BC-9BB3-E835A1063B30_862C7264-8C8A-4217-AFA4-30CD49AC050F_SECURITY";
                    groupName = "F2DEDF6E-393E-42BC-9BB3-E835A1063B30_862C7264-8C8A-4217-AFA4-30CD49AC050F";
                }

                var cacheCfg = new CacheConfiguration
                {
                    Name = cacheName,
                    CacheStoreFactory = new ConstructionTenantCacheStoreFactory(),
                    KeepBinaryInStore = false,  // Cache store works with deserialized data.
                    ReadThrough = true,
                    WriteThrough = true,
                    WriteBehindEnabled = true,
                    QueryEntities = queryList,
                    WriteBehindFlushThreadCount = 2,
                    CacheMode = CacheMode.Partitioned,
                    Backups = backupNodes,
                    DataRegionName = "IgniteDataRegion",
                    EvictionPolicy = new LruEvictionPolicy
                    {
                        MaxSize = 100000
                    },
                    EnableStatistics = cacheMetrics,
                    WriteSynchronizationMode = CacheWriteSynchronizationMode.FullSync,
                    GroupName = groupName
                };
                ICache<string, IConstructionCacheStore> cache = Ignite.GetOrCreateCache<string, IConstructionCacheStore>(cacheCfg);

            }

        }
    }
}
