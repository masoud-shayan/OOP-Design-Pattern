namespace NullObject
{
    public class MobileRepository
    {
        public IMobile GetMobileByName(string mobileName)
        {
            switch (mobileName)
            {
                case "sony":
                    return new SonyXperia();
                
                case "apple":
                    return new AppleIPhone();

                case "samsung":
                    return new SamsungGalaxy();
            }

            return new NullMobile();
            
            
            // otherwise we should do this : 

        }
    }
}