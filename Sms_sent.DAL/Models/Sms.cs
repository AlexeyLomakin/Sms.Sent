using System;
using System.ComponentModel.DataAnnotations;

namespace Sms.Sent.DAL.Models
{
    public class Sms
    {
        private int Id { get; set; }

        [Required(ErrorMessage = "Sender phone can't be null")]
        private string SenderPhone { get; set; }

        [Required(ErrorMessage = "Recepient phone can't be null")]
        private string RecepientPhone { get; set; }

        private string SmsText { get; set; }
    }
}
