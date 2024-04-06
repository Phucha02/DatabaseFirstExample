using System.ComponentModel;

namespace DatabaseFirstExample.Application.Dtos
{
    public class DepartmentUpdateDto
    {
        [DisplayName("Tên khoa")]
        public string Name { get; set; }
    }
}
