using System.ComponentModel;
using Microsoft.EntityFrameworkCore;

namespace DatabaseFirstExample.Application.Dtos
{
    public class DeparmentCreateDto
    {
        [DisplayName("Tên khoa")]
        public string Name { get; set; }
    }
}
