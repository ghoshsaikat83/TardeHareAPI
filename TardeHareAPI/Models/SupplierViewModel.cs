﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TardeHareAPI.Models
{
    public class SupplierViewModel
    {
        public int SupId { get; set; }
        public string SupplierName { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string ContactPerson { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Email1 { get; set; }
        public string Email2 { get; set; }
        public byte Active { get; set; }
        public System.DateTime Updt_Time { get; set; }
    }
}