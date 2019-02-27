using System;
using System.Linq.Expressions;
using Resort.Domain.Entities;

namespace Resort.Application.User.Restaurant.Restaurant.Query
{
    public class RestaurantModel
    {
        public long Id { get; set; }
        public CategoryModel CategoryId { get; set; }
        public string Name { get; set; }
        public RestaurantTypeModel RestaurantTypeId { get; set; }
        public RestaurantReservationStatusModel ReservationStatus { get; set; }
        public decimal? PriceRange { get; set; }
        public string Price { get; set; }
        public string CreditCard { get; set; }
        public string Wifi { get; set; }
        public string Drink { get; set; }
        public string MealService { get; set; }
        public string DiningOption { get; set; }
        public string Restroom { get; set; }
        public string Parking { get; set; }

        public static Expression<Func<Domain.Entities.Restaurant, RestaurantModel>> Projection
        {
            get 
            { 
                return x => new RestaurantModel()
                {
                    Id=x.Id,
                    CategoryId = CategoryModel.FromEntity(x.Category),
                    Name = x.Name,
                    RestaurantTypeId = RestaurantTypeModel.FromEntity(x.RestaurantType),
//                    ReservationStatus = RestaurantReservationStatusModel.FromEntity(),
                    PriceRange = x.PriceRange,
                    Price = x.Price,
                    CreditCard = x.CreditCard,
                    Wifi = x.Wifi,
                    Drink = x.Drink,
                    MealService = x.MealService,
                    DiningOption = x.DiningOption,
                    Restroom = x.Restroom,
                    Parking = x.Parking
                };
            }
        }
    }

    public class RestaurantTypeModel
    {
        public long Id { get; set; }
        public string Name { get; set; }

        public static Expression<Func<RestaurantType, RestaurantTypeModel>> Projection
        {
            get
            {
                return x=>new RestaurantTypeModel
                {
                    Id = x.Id,
                    Name = x.Name
                };
            }
        }

        public static RestaurantTypeModel FromEntity(RestaurantType entity)
        {
            return Projection.Compile().Invoke(entity);
        }
    }

    public class RestaurantReservationStatusModel
    {
        public long Id { get; set; }
        public string Status { get; set; }

        public static Expression<Func<RestaurantReservation, RestaurantReservationStatusModel>> Projection
        {
            get
            {
                return x => new RestaurantReservationStatusModel
                {
                    Id = x.Id,
                    Status = x.Status
                };
            }
        }

        public static RestaurantReservationStatusModel FromEntity(RestaurantReservation entity)
        {
            return Projection.Compile().Invoke(entity);
        }
    }
}