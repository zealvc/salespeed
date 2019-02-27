using System;
using System.Linq.Expressions;
using Resort.Domain.Entities;

namespace Resort.Application.User.Activity.Activity.Query
{
    public class ActivityModel
    {
        public long Id { get; set; }
        public CategoryModel CategoryId { get; set; }
        public string Name { get; set; }
        public ActivityTypeModel ActivityTypeId { get; set; }
        public DateTime? Duration { get; set; }
        public string PricePerPerson { get; set; }
        public string LanguageAvailable { get; set; }
        public string Include { get; set; }
        public long? LocationId { get; set; }
        public string ToDo { get; set; }
        public string Provide { get; set; }
        public string ToBring { get; set; }
        public string OtherDescription { get; set; }
        public int? GroupSize { get; set; }
        public string WhoCanCome { get; set; }
        public string CancellationPolicy { get; set; }
        public long? LanguageId { get; set; }

        public static Expression<Func<Domain.Entities.Activity, ActivityModel>> Projection
        {
            get
            {
                return x=>new ActivityModel
                {
                    Id=x.Id,
                    CategoryId = CategoryModel.FromEntity(x.Category),
                    Name = x.Name,
                    ActivityTypeId = ActivityTypeModel.FromEntity(x.ActivityType),
                    Duration = x.Duration,
                    PricePerPerson = x.PricePerPerson,
                    Include = x.Include,
                    ToDo = x.ToDo,
                    Provide = x.Provide,
                    ToBring = x.ToBring,
                    OtherDescription = x.OtherDescription,
                    GroupSize = x.GroupSize,
                    WhoCanCome = x.WhoCanCome,
                    CancellationPolicy = x.CancellationPolicy,
                };
            }
        }
    }

    public class ActivityTypeModel
    {
        public long Id { get; set; }
        public string Name { get; set; }

        public static Expression<Func<ActivityType, ActivityTypeModel>> Projection
        {
            get
            {
                return x=>new ActivityTypeModel
                {
                    Id = x.Id,
                    Name = x.Name
                };
            }
        }

        public static ActivityTypeModel FromEntity(ActivityType entity)
        {
            return Projection.Compile().Invoke(entity);
        }
    }
}