namespace Stolarus2.Helpers
{
    public static class UIHelpers
    {
        public static string GetPath(this string id)
        {
            return "/Images/Image/" + id;
        }

        public static string GetPath(this string id, int width, int height)
        {
            return "/Images/Image/" + id + "?width=" + width + "&height=" + height;
        }

        public static string GetPath(this string id, int width, int height, bool crop, bool center)
        {
            return "/Images/Image/" + id + "?width=" + width + "&height=" + height + "&crop=" + crop + "&center=" + center;
        }
    }
}