using System;

namespace Infrastructure.Extensions
{
    public static class RandomExtensions
    {

        public static int GetEnumValue<T>(this Random random)
        {
            var values = Enum.GetValues(typeof(T));
            var randomIndex = random.Next(values.Length);

            var choice = (int) values.GetValue(randomIndex);

            return choice;  
        }
        
    }
}