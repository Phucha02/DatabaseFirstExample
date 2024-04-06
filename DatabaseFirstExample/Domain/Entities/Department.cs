using System;
using System.Collections.Generic;

namespace DatabaseFirstExample.Domain.Entities;

public partial class Department
{
    public Guid Id { get; set; }

    /// <summary>
    /// Tên khoa
    /// </summary>
    public string Name { get; set; } = null!;

    public virtual ICollection<Grade> Grades { get; set; } = new List<Grade>();
}
