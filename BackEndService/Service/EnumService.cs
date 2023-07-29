using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndService.Service
{
    public static class EnumService
    {
        public static string EnumToString(Faculty value)
        {
            return value.ToString().Replace("_", " ");
        }
        public static Faculty StringToEnum(string value)
        {
            return (Faculty)Enum.Parse(typeof(Faculty), value.Replace(" ", "_"));
        }

    }
}
