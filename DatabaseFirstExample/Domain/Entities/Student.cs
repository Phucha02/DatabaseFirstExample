using System;
using System.Collections.Generic;

namespace DatabaseFirstExample.Domain.Entities;

public partial class Student
{
    public Guid Id { get; set; }

    /// <summary>
    /// Tên sinh viên
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Mã sinh viên
    /// </summary>
    public string StudentId { get; set; } = null!;

    /// <summary>
    /// Ngày sinh
    /// </summary>
    public DateTime Dob { get; set; }

    /// <summary>
    /// Mã lớp
    /// </summary>
    public Guid GradeId { get; set; }

    public virtual Grade Grade { get; set; } = null!;
}
