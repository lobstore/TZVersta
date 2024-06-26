using System.ComponentModel.DataAnnotations;

namespace TZVersta.Models
{
    public class Order
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Город отправителя обязателен для заполнения.")]
        public string? SenderCity { get; set; }
        [Required(ErrorMessage = "Адрес отправителя обязателен для заполнения.")]
        public string? SenderAddress { get; set; }
        [Required(ErrorMessage = "Город получателя обязателен для заполнения.")]
        public string? RecipientCity { get; set; }
        [Required(ErrorMessage = "Адрес получателя обязателен для заполнения.")]
        public string? RecipientAddress { get; set; }
        [Required(ErrorMessage = "Вес посылки обязателен для заполнения.")]
        public int Weight { get; set; }
        [Required(ErrorMessage = "Дата получения обязательна для заполнения.")]
        public DateTime PickupDate { get; set; }
        public string? OrderNumber { get; set; }
    }
}
