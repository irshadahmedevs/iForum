﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iInfrastructure.Entities;

namespace iForumEntities.Common
{
    public class Province : iEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Code { get; set; }

        public int CountryId { get; set; }
        public virtual Country Country { get; set; }

        public virtual ICollection<City> Cities { get; set; }
    }
}
