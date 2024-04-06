using System;
using System.Collections.Generic;

namespace DatabaseFirstExample.Domain.Entities;

public partial class Grade
{
    public Guid Id { get; set; }

    /// <summary>
    /// Tên lớp
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Khoa
    /// </summary>
    public Guid DepartmentId { get; set; }

    public virtual Department Department { get; set; } = null!;

    public virtual ICollection<Student> Students { get; set; } = new List<Student>();
}
