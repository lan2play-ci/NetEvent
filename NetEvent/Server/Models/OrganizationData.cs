﻿using System.ComponentModel.DataAnnotations;

namespace NetEvent.Server.Models
{
    public class OrganizationData
    {
        [Key]
        public string? Key { get; set; }

        public string? Value { get; set; }
    }
}
