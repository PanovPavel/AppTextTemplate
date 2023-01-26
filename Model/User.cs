﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27.Model
{
    internal class User : EntityBase
    {
        public string? Name { get; set; }
        public string? UserName { get; set; }
        public bool? IsBlocked { get; set; }
        public bool? IsStoped { get; set; }
        public bool? IsMailingAgreement { get; set; }

        public User() {

        }
    }
}
