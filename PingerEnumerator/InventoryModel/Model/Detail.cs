﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryModel.Model
{
    public class Detail
    {
        public int Id { get;set;}

        public virtual DataKey DataKey { get; set; }

        public string Properties { get; set; }
        public virtual Node Node { get; set; }
    }
}
