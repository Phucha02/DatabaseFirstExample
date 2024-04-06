using System.ComponentModel;

namespace DatabaseFirstExample.Application.Dtos
{
    public class GradeFilterDto
    {
        [DisplayName("Mã khoa")]
        public Guid? DepartmentId { get; set; }

        [DisplayName("Mã lớp")]
        public Guid? Id { get; set; }

        [DisplayName("Tên lớp")]
        public string? Name { get; set; }
    }
}
