using System;
 
namespace Pelijuttujentaustat
{
    public class Log
    {
        public Guid Id { get; set; }
        public string Text { get; set; }
 
        public Log(string text)
        {
            Id = Guid.NewGuid();
            Text = text;
        }
    }
}