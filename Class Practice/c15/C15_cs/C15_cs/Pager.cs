using System;

namespace C15
{
    internal class Pager
    {
        private MailManager mm;

        public Pager(MailManager mm)
        {
            this.mm = mm;
        }

        public void Page(string msg)
        {
            Console.WriteLine($"Paging: {msg}");            
        }

    }
}