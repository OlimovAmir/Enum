using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    public class ClassDayOfWeek
    {
        public enum DayOfWeek : byte
        {
            Monday = 1,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        public void getTypeEnum()
        {
            Type enumType = typeof(DayOfWeek);
            //TypeCode typeCode = Type.GetTypeCode(enumType);

            Console.WriteLine(Type.GetTypeCode(enumType)); // Output: Int32

            Console.WriteLine((DayOfWeek)3);
            Console.WriteLine((byte)DayOfWeek.Sunday);

        }
    }
}
