﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KsooShop.Model.Abstract
{
    public class Auditable : IAuditable
    {
        public DateTime? CreatedDate { set; get; }
        [MaxLength(256)]
        public string CreatedBy { set; get; }
        public DateTime? UpdatedDate { set; get; }
        [MaxLength(256)]
        public string UpdatedBy { set; get; }
        [MaxLength(256)]
        public string MetaKeyword { set; get; }
        [MaxLength(256)]
        public string MetaDescripton { set; get; }
        public bool Status { set; get; }
    }
}
