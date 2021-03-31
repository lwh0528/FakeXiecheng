using System;
using System.Collections.Generic;

namespace FakeXiecheng.Models
{
    public  class TouristRoute                          //
    {
        //基础属性
        public Guid Id { get; set; }
        public string  Title { get; set; }
        public string Description { get; set; }
        public decimal OriginalPrice { get; set; }
        public double? DiscountPresent { get; set; }    //
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }        //
        public DateTime? DepartureTime { get; set; }    //
        public string Feature { get; set; }
        public string Fees { get; set; }                //费用说明
        public string Notes { get; set; }
        public double? Rating { get; set; }
        public TravelDays? TravelDays { get; set; }
        public TripType? TripType { get; set; }
        public DepartureCity? DepartureCity { get; set; }

        //导航属性
        public ICollection<TouristRoutePicture> TouristRoutePictures { get; set; } = new List<TouristRoutePicture>();
    }
}
