using System;
using System.ComponentModel.DataAnnotations;
using BLL.DTO.Abstract;

namespace BLL.DTO
{
    public class OrderDto : BaseBllEntity
    {
        [Required]
        public DateTime DateOfCreation { get; set; }
        [Required]
        public int StageId { get; set; }
        [Required]
        public int ProductId { get; set; }
        [Required]
        public double ProductPrice { get; set; }
        [Required]
        public double Amount { get; set; }
    }
}
