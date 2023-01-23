using System;
using System.ComponentModel.DataAnnotations;

namespace Sms.Sent.DAL.Models
{
    public class SmsModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Recepient phone can't be null")]
        public int RecepientPhone { get; set; }

        public string SmsText { get; set; }
        public DateTime DateSend { get; set; }
        public string SmsStatus { get; set; }
    }
}
