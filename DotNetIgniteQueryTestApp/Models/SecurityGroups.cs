using Apache.Ignite.Core.Cache.Configuration;
using DotNetIgniteQueryTestApp.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetIgniteQueryTestApp.Models
{
    public class SecurityGroups : IConstructionCacheStore
    {
        [QuerySqlField]
        public string SecurityGroupId { get; set; }
        [QuerySqlField]
        public string SGEntityId { get; set; }
        [QuerySqlField]
        public string SGEntityType { get; set; }
        [QuerySqlField]
        public string SGEntityName { get; set; }
        [QuerySqlField]
        public string TypeOfEntity { get; set; }
        [QuerySqlField]
        public string CapabilityName { get; set; }
        [QuerySqlField]
        public string CapabilityId { get; set; }
        [QuerySqlField]
        private DateTime _CreatedDateTime;
        public DateTime CreatedDateTime
        {
            get { return _CreatedDateTime; }
            set
            {
                _CreatedDateTime = DateTime.SpecifyKind(value != null ? value : DateTime.UtcNow, DateTimeKind.Utc);
            }
        }

        [QuerySqlField]
        private DateTime _ModifiedDateTime;
        public DateTime ModifiedDateTime
        {
            get { return _ModifiedDateTime; }
            set
            {
                _ModifiedDateTime = DateTime.SpecifyKind(value != null ? value : DateTime.UtcNow, DateTimeKind.Utc);
            }
        }
        [QuerySqlField]
        public string CreatedBy { get; set; }
        [QuerySqlField]
        public string ModifiedBy { get; set; }
        [QuerySqlField]
        public string CreatedByUserId { get; set; }
        [QuerySqlField]
        public string ModifiedByUserId { get; set; }
        [QuerySqlField]
        public bool IsDeleted { get; set; }

        public SecurityGroups()
        {
            ModifiedDateTime = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc);
            CreatedDateTime = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc);
        }
    }
}
