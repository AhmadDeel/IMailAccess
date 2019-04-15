using System;

namespace IMailAccess
{
    public class Mail
    {
        public int ID { get; set; }
        public long MailNo { get; set; }
        public DateTime MailDate { get; set; }
        public string Title { get; set; }
        public string Organization { get; set; }
        public string Details { get; set; }
        public bool IsOut { get; set; }
    }
}
