﻿namespace CRUD_API.Models
{
    public class ComplexFilter
    {
        public SexFilter SexFilter { get; set; }
        public AgeFilter AgeFilter { get; set; }
        public OwnerParameters OwnerParameters { get; set; }
    }
}
