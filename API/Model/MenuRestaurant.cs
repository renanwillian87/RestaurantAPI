using System;

namespace Model
{
    public class MenuRestaurant : Base
    {
        public Restaurant Restaurant { get; set; }
        public Guid RestaurantId { get; set; }

        public Menu Menu { get; set; }
        public Guid MenuId { get; set; }
    }
}