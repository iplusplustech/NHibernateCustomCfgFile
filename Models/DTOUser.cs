﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateCustomCfgFile.Models
{
    public class DTOUser
    {
        public virtual string Id { get; set; }
        public virtual string Name { get; set; }

        public virtual short Active { get; set; }


    }
}
