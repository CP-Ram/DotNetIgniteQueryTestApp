using Apache.Ignite.Core.Cache.Configuration;
using DotNetIgniteQueryTestApp.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetIgniteQueryTestApp.Models
{
    public class Tasks_Tasks : IConstructionCacheStore
    {
        [QuerySqlField]
        public bool LevelingCanSplit { get; set; }
        [QuerySqlField]
        public string PercentageWorkComplete { get; set; }
        [QuerySqlField]
        public string UniqueID { get; set; }
        [QuerySqlField]
        private DateTime _SummaryProgress;
        public DateTime SummaryProgress
        {
            get { return _SummaryProgress; }
            set
            {
                _SummaryProgress = DateTime.SpecifyKind(value != null ? value : DateTime.UtcNow, DateTimeKind.Utc);
            }
        }
        [QuerySqlField]
        public bool ResumeValid { get; set; }
        [QuerySqlField]
        private DateTime _Start;
        public DateTime Start
        {
            get { return _Start; }
            set
            {
                _Start = DateTime.SpecifyKind(value != null ? value : DateTime.UtcNow, DateTimeKind.Utc);
            }
        }
        [QuerySqlField]
        public string ActualOvertimeWorkProtected { get; set; }
        [QuerySqlField]
        private DateTime _EarlyFinish;
        public DateTime EarlyFinish
        {
            get { return _EarlyFinish; }
            set
            {
                _EarlyFinish = DateTime.SpecifyKind(value != null ? value : DateTime.UtcNow, DateTimeKind.Utc);
            }
        }
        [QuerySqlField]
        public string BaselineFixedCost { get; set; }
        [QuerySqlField]
        public string BaselineEstimatedDuration { get; set; }
        [QuerySqlField]
        public string FinishSlack { get; set; }
        [QuerySqlField]
        public bool Critical { get; set; }
        [QuerySqlField]
        public string RemainingWork { get; set; }
        [QuerySqlField]
        public string FreeSlack { get; set; }
        [QuerySqlField]
        public string RemainingDuration { get; set; }
        [QuerySqlField]
        public string TaskMode { get; set; }
        [QuerySqlField]
        private DateTime _CreateDate;
        public DateTime CreateDate
        {
            get { return _CreateDate; }
            set
            {
                _CreateDate = DateTime.SpecifyKind(value != null ? value : DateTime.UtcNow, DateTimeKind.Utc);
            }
        }
        [QuerySqlField]
        public string StartSlack { get; set; }
        [QuerySqlField]
        public bool IgnoreResource { get; set; }
        [QuerySqlField]
        public string BaselineCost { get; set; }
        [QuerySqlField]
        public string Work { get; set; }
        [QuerySqlField]
        public string PercentageComplete { get; set; }
        [QuerySqlField]
        public string ID { get; set; }
        [QuerySqlField]
        public string ActualOvertimeCost { get; set; }

        [QuerySqlField]
        public string LevelingDelay { get; set; }

        [QuerySqlField]
        public string DurationVariance { get; set; }

        [QuerySqlField]
        public bool Expanded { get; set; }

        [QuerySqlField]
        public string ActualWork { get; set; }

        [QuerySqlField]
        public bool UpdateNeeded { get; set; }

        [QuerySqlField]
        public bool Milestone { get; set; }

        [QuerySqlField]
        public string Priority { get; set; }

        [QuerySqlField]
        public string OutlineNumber { get; set; }
        [QuerySqlField]
        public string PhysicalPercentComplete { get; set; }
        [QuerySqlField]
        public string Duration { get; set; }
        [QuerySqlField]
        private DateTime _LateStart;
        public DateTime LateStart
        {
            get { return _LateStart; }
            set
            {
                _LateStart = DateTime.SpecifyKind(value != null ? value : DateTime.UtcNow, DateTimeKind.Utc);
            }
        }
        [QuerySqlField]
        public string RemainingOvertimeWork { get; set; }
        [QuerySqlField]
        public bool LevelAssignments { get; set; }
        [QuerySqlField]
        public string EntityType { get; set; }
        [QuerySqlField]
        public bool LinkedFields { get; set; }
        [QuerySqlField]
        public bool Active { get; set; }
        [QuerySqlField]
        public string ActualDuration { get; set; }
        [QuerySqlField]
        private DateTime _BaselineFinish;
        public DateTime BaselineFinish
        {
            get { return _BaselineFinish; }
            set
            {
                _BaselineFinish = DateTime.SpecifyKind(value != null ? value : DateTime.UtcNow, DateTimeKind.Utc);
            }
        }
        [QuerySqlField]
        public string LevelingDelayFormat { get; set; }
        [QuerySqlField]
        public string FixedCost { get; set; }
        [QuerySqlField]
        public bool Confirmed { get; set; }
        [QuerySqlField]
        private DateTime _EarlyStart;
        public DateTime EarlyStart
        {
            get { return _EarlyStart; }
            set
            {
                _EarlyStart = DateTime.SpecifyKind(value != null ? value : DateTime.UtcNow, DateTimeKind.Utc);
            }
        }
        [QuerySqlField]
        public bool Marked { get; set; }
        [QuerySqlField]
        public bool ExternalTask { get; set; }
        [QuerySqlField]
        public string EntityName { get; set; }
        [QuerySqlField]
        public bool Rollup { get; set; }
        [QuerySqlField]
        public string NestedUnderWBS { get; set; }
        [QuerySqlField]
        public string Splits { get; set; }
        [QuerySqlField]
        public string ActualWorkProtected { get; set; }
        [QuerySqlField]
        public string ConstraintType { get; set; }
        [QuerySqlField]
        public string RemainingCost { get; set; }
        [QuerySqlField]
        public bool HideBar { get; set; }
        [QuerySqlField]
        public string Cost { get; set; }
        [QuerySqlField]
        public string ParentTask { get; set; }
        [QuerySqlField]
        public bool Recurring { get; set; }
        [QuerySqlField]
        public string TotalSlack { get; set; }
        [QuerySqlField]
        public string RemainingOvertimeCost { get; set; }
        [QuerySqlField]
        public string BaselineWork { get; set; }
        [QuerySqlField]
        public bool EffortDriven { get; set; }
        [QuerySqlField]
        public bool Estimated { get; set; }
        [QuerySqlField]
        public string FixedCostAccrual { get; set; }
        [QuerySqlField]
        private DateTime _Finish;
        public DateTime Finish
        {
            get { return _Finish; }
            set
            {
                _Finish = DateTime.SpecifyKind(value != null ? value : DateTime.UtcNow, DateTimeKind.Utc);
            }
        }
        [QuerySqlField]
        public string Notes { get; set; }
        [QuerySqlField]
        public string BaselineDuration { get; set; }
        [QuerySqlField]
        public string StartVariance { get; set; }
        [QuerySqlField]
        public string ActivityType { get; set; }
        [QuerySqlField]
        public string WBS { get; set; }

        [QuerySqlField]
        private DateTime _BaselineStart;
        public DateTime BaselineStart
        {
            get { return _BaselineStart; }
            set
            {
                _BaselineStart = DateTime.SpecifyKind(value != null ? value : DateTime.UtcNow, DateTimeKind.Utc);
            }
        }
        [QuerySqlField]
        public string FinishVariance { get; set; }
        [QuerySqlField]
        public string ActualCost { get; set; }
        [QuerySqlField]
        public string EntityId { get; set; }

        [QuerySqlField]
        public string CalendarUniqueID { get; set; }
        [QuerySqlField]
        public string Type { get; set; }
        [QuerySqlField]
        public string CV { get; set; }
        [QuerySqlField]
        public string WorkVariance { get; set; }
        [QuerySqlField]
        private DateTime _BaselineEstimatedStart;
        public DateTime BaselineEstimatedStart
        {
            get { return _BaselineEstimatedStart; }
            set
            {
                _BaselineEstimatedStart = DateTime.SpecifyKind(value != null ? value : DateTime.UtcNow, DateTimeKind.Utc);
            }
        }
        [QuerySqlField]
        public string ActivityCodes { get; set; }
        [QuerySqlField]
        public bool OverAllocated { get; set; }
        [QuerySqlField]
        public string CostVariance { get; set; }
        [QuerySqlField]
        public bool Summary { get; set; }
        [QuerySqlField]
        private DateTime _BaselineEstimatedFinish;
        public DateTime BaselineEstimatedFinish
        {
            get { return _BaselineEstimatedFinish; }
            set
            {
                _BaselineEstimatedFinish = DateTime.SpecifyKind(value != null ? value : DateTime.UtcNow, DateTimeKind.Utc);
            }
        }
        [QuerySqlField]
        public string OvertimeCost { get; set; }
        [QuerySqlField]
        public string OutlineLevel { get; set; }
        [QuerySqlField]
        public string BaselineFixedCostAccrual { get; set; }
        [QuerySqlField]
        private DateTime _LateFinish;
        public DateTime LateFinish
        {
            get { return _LateFinish; }
            set
            {
                _LateFinish = DateTime.SpecifyKind(value != null ? value : DateTime.UtcNow, DateTimeKind.Utc);
            }
        }
        [QuerySqlField]
        private DateTime _Stop;
        public DateTime Stop
        {
            get { return _Stop; }
            set
            {
                _Stop = DateTime.SpecifyKind(value != null ? value : DateTime.UtcNow, DateTimeKind.Utc);
            }
        }
        [QuerySqlField]
        private DateTime _CompleteThrough;
        public DateTime CompleteThrough
        {
            get { return _CompleteThrough; }
            set
            {
                _CompleteThrough = DateTime.SpecifyKind(value != null ? value : DateTime.UtcNow, DateTimeKind.Utc);
            }
        }
        [QuerySqlField]
        private DateTime _ActualStart;
        public DateTime ActualStart
        {
            get { return _ActualStart; }
            set
            {
                _ActualStart = DateTime.SpecifyKind(value != null ? value : DateTime.UtcNow, DateTimeKind.Utc);
            }
        }

        [QuerySqlField]
        private DateTime _Resume;
        public DateTime Resume
        {
            get { return _Resume; }
            set
            {
                _Resume = DateTime.SpecifyKind(value != null ? value : DateTime.UtcNow, DateTimeKind.Utc);
            }
        }
        [QuerySqlField]
        public string ManualDuration { get; set; }
        [QuerySqlField]
        public string NestedUnderId { get; set; }
        [QuerySqlField]
        public string NestedUnderName { get; set; }
        [QuerySqlField]
        private DateTime _ActualFinish;
        public DateTime ActualFinish
        {
            get { return _ActualFinish; }
            set
            {
                _ActualFinish = DateTime.SpecifyKind(value != null ? value : DateTime.UtcNow, DateTimeKind.Utc);
            }
        }
        [QuerySqlField]
        public string ActualOvertimeWork { get; set; }
        [QuerySqlField]
        public string ACWP { get; set; }
        [QuerySqlField]
        public string BaselineDurationText { get; set; }
        [QuerySqlField]
        public string BaselineFinishText { get; set; }
        [QuerySqlField]
        public string BCWP { get; set; }
        [QuerySqlField]
        public string BCWS { get; set; }
        [QuerySqlField]
        public string Calendar { get; set; }
        [QuerySqlField]
        private DateTime _ConstraintDate;
        public DateTime ConstraintDate
        {
            get { return _ConstraintDate; }
            set
            {
                _ConstraintDate = DateTime.SpecifyKind(value != null ? value : DateTime.UtcNow, DateTimeKind.Utc);
            }
        }
        [QuerySqlField]
        public string Contact { get; set; }
        [QuerySqlField]
        private DateTime _Deadline;
        public DateTime Deadline
        {
            get { return _Deadline; }
            set
            {
                _Deadline = DateTime.SpecifyKind(value != null ? value : DateTime.UtcNow, DateTimeKind.Utc);
            }
        }
        [QuerySqlField]
        public string ExternalTaskProject { get; set; }
        [QuerySqlField]
        public string FinishText { get; set; }
        [QuerySqlField]
        public string HyperlinkAddress { get; set; }
        [QuerySqlField]
        public string HyperlinkSubAddress { get; set; }
        [QuerySqlField]
        public string Objects { get; set; }
        [QuerySqlField]
        public string OvertimeWork { get; set; }
        [QuerySqlField]
        private DateTime _PreleveledFinish;
        public DateTime PreleveledFinish
        {
            get { return _PreleveledFinish; }
            set
            {
                _PreleveledFinish = DateTime.SpecifyKind(value != null ? value : DateTime.UtcNow, DateTimeKind.Utc);
            }
        }
        [QuerySqlField]
        private DateTime _PreleveledStart;
        public DateTime PreleveledStart
        {
            get { return _PreleveledStart; }
            set
            {
                _PreleveledStart = DateTime.SpecifyKind(value != null ? value : DateTime.UtcNow, DateTimeKind.Utc);
            }
        }
        [QuerySqlField]
        public string Project { get; set; }
        [QuerySqlField]
        public string RegularWork { get; set; }
        [QuerySqlField]
        private DateTime _RemainingEarlyFinish;
        public DateTime RemainingEarlyFinish
        {
            get { return _RemainingEarlyFinish; }
            set
            {
                _RemainingEarlyFinish = DateTime.SpecifyKind(value != null ? value : DateTime.UtcNow, DateTimeKind.Utc);
            }
        }
        [QuerySqlField]
        private DateTime _RemainingEarlyStart;
        public DateTime RemainingEarlyStart
        {
            get { return _RemainingEarlyStart; }
            set
            {
                _RemainingEarlyStart = DateTime.SpecifyKind(value != null ? value : DateTime.UtcNow, DateTimeKind.Utc);
            }
        }
        [QuerySqlField]
        private DateTime _SecondaryConstraintDate;
        public DateTime SecondaryConstraintDate
        {
            get { return _SecondaryConstraintDate; }
            set
            {
                _SecondaryConstraintDate = DateTime.SpecifyKind(value != null ? value : DateTime.UtcNow, DateTimeKind.Utc);
            }
        }
        [QuerySqlField]
        public string SecondaryConstraintType { get; set; }
        [QuerySqlField]
        public string SplitCompleteDuration { get; set; }
        [QuerySqlField]
        public string StartText { get; set; }
        [QuerySqlField]
        public string SV { get; set; }
        [QuerySqlField]
        public bool IsDeleted { get; set; }
        [QuerySqlField]
        public string VisurProjectID { get; set; }
        [QuerySqlField]
        public string parententityid { get; set; }
        [QuerySqlField]
        public string ModifiedBy { get; set; }
        [QuerySqlField]
        public string CreatedBy { get; set; }
        [QuerySqlField]
        public string CreatedByUserId { get; set; }
        [QuerySqlField]
        public string ModifiedByUserId { get; set; }
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
        private DateTime _SyncDateTime;
        public DateTime SyncDateTime
        {
            get { return _SyncDateTime; }
            set
            {
                _SyncDateTime = DateTime.SpecifyKind(value != null ? value : DateTime.UtcNow, DateTimeKind.Utc);
            }
        }

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

        public Tasks_Tasks()
        {
            CreatedDateTime = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc);
            ModifiedDateTime = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc);
            SyncDateTime = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc);
            SecondaryConstraintDate = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc);
            RemainingEarlyStart = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc);
            RemainingEarlyFinish = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc);
            PreleveledStart = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc);
            PreleveledFinish = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc);
            Deadline = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc);
            ConstraintDate = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc);
            ActualFinish = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc);
            Resume = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc);
            ActualStart = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc);
            CompleteThrough = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc);
            Stop = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc);
            LateFinish = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc);
            BaselineEstimatedFinish = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc);
            BaselineEstimatedStart = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc);
            BaselineStart = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc);
            Finish = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc);
            EarlyStart = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc);
            BaselineFinish = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc);
            LateStart = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc);
            CreateDate = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc);
            EarlyFinish = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc);
            Start = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc);
            SummaryProgress = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc);
        }
    }
}
