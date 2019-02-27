using Resort.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Microsoft.EntityFrameworkCore.Query.ExpressionVisitors.Internal;

namespace Resort.Application
{
    public class AccommodationModel
    {
        public long Id { get; set; }
        
        public string Name { get; set; }
        public CategoryModel Category { get; set; }
        public string Description { get; set; }
        public int? GuestCount { get; set; }
        public int? BedRoomCount { get; set; }
        public int? BedCount { get; set; }
        public int? BathCount { get; set; }
        public decimal? PricePerNight { get; set; }
        public string CoverImage { get; set; }
        public string MainImage { get; set; }
        public string CancellationPolicy { get; set; }
        public DateTime? DateAdded { get; set; }
        public AccommodationTypeModel AccommodationType { get; set; }
        
        public AccommodationHouseRuleModel2 AccommodationHouseRule { get; set; }

        public static Expression<Func<Domain.Entities.Accommodation ,AccommodationModel>> Projection
        {
            get
            {
                return x => new AccommodationModel
                {
                    Id = x.Id,
                    Category = CategoryModel.FromEntity(x.Category),
                    Name = x.Name,
                    AccommodationType = AccommodationTypeModel.FromEntity(x.AccommodationType),
                    Description = x.Description,
                    GuestCount = x.GuestCount,
                    BedRoomCount = x.BedRoomCount,
                    BedCount = x.BedCount,
                    BathCount = x.BathCount,
                    PricePerNight = x.PricePerNight,
                    CoverImage = x.CoverImage,
                    MainImage = x.MainImage,
                    CancellationPolicy = x.CancellationPolicy,
                    DateAdded = x.DateAdded,
                    AccommodationHouseRule = AccommodationHouseRuleModel2.FromEntity(x.AccommodationHouseRule)
                };
            }
        }
    }
    public class CategoryModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Modify { get; set; }
        public string Status { get; set; }

        public static Expression<Func<Category, CategoryModel>> Projection
        {
            get
            {
                return x=>new CategoryModel
                {
                    Id=x.Id,
                    Name = x.Name,
                    Description = x.Description,
                    Created=x.Created,
                    Modify = x.Modify,
                    Status = x.Status
                };
            }
        }

        public static CategoryModel FromEntity(Category entity)
        {
            return Projection.Compile().Invoke(entity);
        }
    }

    public class AccommodationTypeModel
    {
        public long Id { get; set; }
        public string Type { get; set; }

        public static Expression<Func<AccommodationType, AccommodationTypeModel>> Projection
        {
            get 
            { 
                return x => new AccommodationTypeModel
                {
                    Id=x.Id,
                    Type=x.Type
                }; 
            }
        }

        public static AccommodationTypeModel FromEntity(AccommodationType entity)
        {
            return Projection.Compile().Invoke(entity);
        }
    }

    public class AccommodationHouseRuleModel2
    {
//        public long AccommodationId { get; set; }
        public HouseRuleModel HouseRuleId { get; set; }

        public static Expression<Func<AccommodationHouseRule, AccommodationHouseRuleModel2>> Projection
        {
            get
            {
                return x=>new AccommodationHouseRuleModel2()
                {
//                    AccommodationId = x.AccommodationId,
                    HouseRuleId = HouseRuleModel.FromEntity(x.HouseRule)
                };
            }
        }

        public static AccommodationHouseRuleModel2 FromEntity(AccommodationHouseRule entity)
        {
            return Projection.Compile().Invoke(entity);
        }
    }

    public class HouseRuleModel
    {
        public HouseRuleDescriptionModel Id { get; set; }
        public string Name { get; set; }

        public static Expression<Func<HouseRule, HouseRuleModel>> Projection
        {
            get
            {
                return x => new HouseRuleModel
                {
                    Id = HouseRuleDescriptionModel.FromEntity(x.HouseRuleDescription),
                    Name = x.Name
                };
            }
        }

        public static HouseRuleModel FromEntity(HouseRule entity)
        {
            return Projection.Compile().Invoke(entity);
        }
    }

    public class HouseRuleDescriptionModel
    {
        public long HouseRuleId { get; set; }
        public string HouseRuleDescription1 { get; set; }

        public static Expression<Func<HouseRuleDescription, HouseRuleDescriptionModel>> Projection
        {
            get
            {
                return x => new HouseRuleDescriptionModel
                {
                    HouseRuleId = x.HouseRuleId,
                    HouseRuleDescription1 = x.HouseRuleDescription1
                };
            }
        }

        public static HouseRuleDescriptionModel FromEntity(HouseRuleDescription entity)
        {
            return Projection.Compile().Invoke(entity);
        }
    }
}
