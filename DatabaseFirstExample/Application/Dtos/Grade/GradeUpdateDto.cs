using System.ComponentModel;

namespace DatabaseFirstExample.Application.Dtos
{
    public class GradeUpdateDto
    {
        [DisplayName("Mã khoa")]
        public Guid? DepartmentId { get; set; }

        [DisplayName("Tên lớp")]
        public string Name { get; set; }
    }
}
