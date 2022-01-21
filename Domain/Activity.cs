using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain
{
    public class Activity
    {
         // advantage of using Guid is that if the id i created on the client 
	//side then we dont need to wait for our
        // datebase server to generate the Id for us  
        public Guid Id { get; set; } 
        public string Title { get; set; }
        public DateTime Date { get; set; }

        public string Description { get; set; }
        public string Category { get; set; }
        public string City { get; set; }
        public string Venue { get; set; }
    }
}