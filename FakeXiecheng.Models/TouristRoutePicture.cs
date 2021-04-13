using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FakeXiecheng.Models
{
    public class TouristRoutePicture
    {
        //基础属性
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [MaxLength(100)]
        public string Url { get; set; }

        //外键属性
        [ForeignKey("TouristRouteId")]
        public Guid TouristRouteId { get; set; }
        //导航属性
        public TouristRoute TouristRoute { get; set; }
    }
}