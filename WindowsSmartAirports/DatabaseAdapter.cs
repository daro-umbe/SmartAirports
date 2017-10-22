using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace WindowsSmartAirports
{
    public static class DatabaseAdapter
    {
        private static geartestEntities entities;

        public static geartestEntities GearboxEntities
        {
            get
            {
                if (entities == null)
                    return new geartestEntities();
                else
                    return entities;
            }
        }

    }
}