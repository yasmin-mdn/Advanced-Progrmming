using System;

namespace C15
{
    internal class Fax
    {
        private MailManager mm;

        public Fax(MailManager mm)
        {
            this.mm = mm;
        }

        private void SendFax(string msg)
        {
            Console.WriteLine($"Fax Sent: {msg}");            
        }

        public void Register(MailManager mm)
        {
            mm.NewMail +=(MailInfo m)=>SendFax($"{m.From}:{m.To}:{m.Title}") ;

     /*   public void UnRegister()
        {
            mm.NewMa
        }*/
    }
}}