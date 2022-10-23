using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestAPI
{
    public class Data
    {
        private int _id;
        private string _city;
        private string _name;
        private int _estimated_cost;
        private UserRating _userRating;

        public int Id { get => _id; set => _id = value; }
        public string City { get => _city; set => _city = value; }
        public string Name { get => _name; set => _name = value; }
        public int Estimated_Cost { get => _estimated_cost; set => _estimated_cost = value; }
        public UserRating UserRating { get => _userRating; set => _userRating = value; }
    }

    public class UserRating
    {
        private float _average_rating;
        private int _votes;

        public float Average_Rating { get => _average_rating; set => _average_rating = value; }
        public int Votes { get => _votes; set => _votes = value; }

    }

}
