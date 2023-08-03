namespace managementcheck.Service
{
    public static class EnumService
    {
        public static string EnumToString(this Faculty value)
        {
            return value.ToString().Replace("_", " ");
        }
        public static Faculty StringToEnum(this string value)
        {
            return (Faculty)Enum.Parse(typeof(Faculty), value.Replace(" ", "_"));
        }

    }
}
