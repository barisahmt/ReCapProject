namespace Core.Utilites.Helper.GUIDHelper;

public class GuidHelper
{
    public static string CreateGuid()
    {
        return Guid.NewGuid().ToString();
    }
}