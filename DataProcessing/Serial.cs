using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProcessing
{
    public class Serial
    {
        public Serial() { }
        public string Name { get; set; } = null;
        public string Genre { get; set; } = null;
        public string Released { get; set; } = null;
        public string Rating { get; set; } = null;
        public string Seasons { get; set; } = null;
        public string Country { get; set; } = null;

        public bool Compare(Serial obj)
        {
            if (this.Name == obj.Name && this.Genre == obj.Genre && this.Released == obj.Released &&
                this.Rating == obj.Rating && this.Seasons == obj.Seasons && this.Country == obj.Country)
                return true;
            return false;
        }

    }
}
