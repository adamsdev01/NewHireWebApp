using System;
using System.Collections.Generic;

namespace BlazorApp1.Data.Models
{
    public partial class NewHire
    {
        public long Id { get; set; }
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public int? Age { get; set; }
        public string? JobTitle { get; set; }
        public string? DepartmentName { get; set; }
        public string? Salary { get; set; }
        public DateTime? HireDate { get; set; }
        public DateTime? StartDate { get; set; }
        public string? Shift { get; set; }
        public string? ImageFileName { get; set; }
        public byte[]? ImageBytes { get; set; }
        public string? FileType { get; set; }
        public string? IsCurrent { get; set; }
        public DateTime? InsertedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
