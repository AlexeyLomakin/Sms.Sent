using System;

namespace Sms_Sent.BLL.Helpers
{
    static class Randomizer
    {
        public static int  GetRandomStatus() 
        {
            var rand = new Random();
            return rand.Next(1, 3);
        }
       
    }
}
