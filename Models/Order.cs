using System.ComponentModel.DataAnnotations;

namespace TZVersta.Models
{
    public class Order
    {
        public int Id { get; set; }

        [Display(Name = "Город отправителя")]
        [Required(ErrorMessage = "Город отправителя обязателен для заполнения.")]
        public string? SenderCity { get; set; }

        [Display(Name = "Адрес отправителя")]
        [Required(ErrorMessage = "Адрес отправителя обязателен для заполнения.")]
        public string? SenderAddress { get; set; }

        [Display(Name = "Город получателя")]
        [Required(ErrorMessage = "Город получателя обязателен для заполнения.")]
        public string? RecipientCity { get; set; }

        [Display(Name = "Адрес получателя")]
        [Required(ErrorMessage = "Адрес получателя обязателен для заполнения.")]
        public string? RecipientAddress { get; set; }

        [Display(Name = "Вес груза")]
        [Required(ErrorMessage = "Вес груза обязателен для заполнения.")]
        public int Weight { get; set; }

        [Display(Name = "Дата забора заказа")]
        [Required(ErrorMessage = "Дата получения обязательна для заполнения.")]
        public DateTime PickupDate { get; set; }
        public string? OrderNumber { get; set; }
    }
}
