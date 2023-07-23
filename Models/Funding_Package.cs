﻿using System.ComponentModel.DataAnnotations;

namespace ReGenerationProjectAssignment_FundRaiser.Models
{
    public class Funding_Package
    {
        [Key]
        public int PackageId { get; set; }
        public string? PackageName { get; set; }
        public int PackageValue { get; set; }
        public string? PackageReward{ get; set; }
        public virtual List<Project> Project { get; set; } = new List<Project>();
    }
}
