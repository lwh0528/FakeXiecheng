using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FakeXiecheng.Models
{
    public  class TouristRoute                          //
    {
        //基础属性
        [Key]
        public Guid Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string  Title { get; set; }
        [MaxLength(1500)]
        public string Description { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal OriginalPrice { get; set; }
        [Range(0.0,1.0)]
        public double? DiscountPresent { get; set; }    //
        public DateTime CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }        //
        public DateTime? DepartureTime { get; set; }    //
        [MaxLength]
        public string Features { get; set; }
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
