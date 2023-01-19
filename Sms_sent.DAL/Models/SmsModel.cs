using System;
using System.ComponentModel.DataAnnotations;

namespace Sms.Sent.DAL.Models
{
    public class SmsModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Sender phone can't be null")]
        public string SenderPhone { get; set; }

        [Required(ErrorMessage = "Recepient phone can't be null")]
        public string RecepientPhone { get; set; }

        public string SmsText { get; set; }
    }
}
