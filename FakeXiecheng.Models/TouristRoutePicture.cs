using System;

namespace TouristRoute
{
    public class TouristRoutePicture
    {
        //基础属性
        public int Id { get; set; }
        public string Url { get; set; }
        
        //外键属性
        public Guid TouristRouteId { get; set; }
        //导航属性
        public TouristRoute TouristRoute { get; set; }
    }
}