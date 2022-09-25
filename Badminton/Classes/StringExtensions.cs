namespace Badminton.Classes
{
    public static class StringExtensions
    {
        public static string FormatForFileName(this string s)
        {
            return string.Join("_", s.Split(Path.GetInvalidFileNameChars()));
        }
    }
}
