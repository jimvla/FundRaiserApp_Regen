﻿namespace ReGenerationProjectAssignment_FundRaiser.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserSurName { get; set; }

        public virtual IEnumerable<Project> Projects { get; set; } = new List<Project>();
    }
}
