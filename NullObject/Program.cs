using System;

namespace NullObject
{
    class Program
    {
        static void Main(string[] args)
        {
            var mobileRepository = new MobileRepository();  
            IMobile mobile = mobileRepository.GetMobileByName("sony");  
            mobile.TurnOn();  
            mobile.TurnOff(); 
            
            
            
            // otherwise if we would not use null object pattern, we should do this : 
            
            // var mobileRepository = new MobileRepository();  
            // IMobile mobile = mobileRepository.GetMobileByName("sony");
            // if (mobile != null)
            // {
            //     mobile.TurnOff();
            //     mobile.TurnOn();
            // }
        }
    }
}