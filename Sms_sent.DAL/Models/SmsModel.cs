using System;
using System.ComponentModel.DataAnnotations;

namespace Sms.Sent.DAL.Models
{
    public class SmsModel
    {
        [Key]
        //Идентификатор СМС
        public int Id { get; set; }

        //Номер отправителя
        public string RecepientPhone { get; set; }

        //Текст СМС
        public string SmsText { get; set; }

        //Время отправки
        public DateTime DateSend { get; set; }

        //статус СМС
        public string SmsStatus { get; set; }
    }
}
