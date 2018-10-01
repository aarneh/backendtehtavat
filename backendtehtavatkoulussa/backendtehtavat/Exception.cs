using System;
using System.Web;
using Microsoft.AspNetCore.Http;

namespace Pelijuttujentaustat
{
    public class LevelRequirementException : Exception
    {
        public LevelRequirementException()
        {

        }

        public LevelRequirementException(string message) : base(message)
        {

        }

        public LevelRequirementException(string message, Exception inner) : base(message, inner)
        {

        }
    }
}