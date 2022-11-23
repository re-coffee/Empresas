foreach (var arg in args)
{
    try
    {
        Type type = Type.GetType($"ApControle.Classes.{arg}", false, false);
        object oClass = Activator.CreateInstance(type);
    }
    catch { continue; }
}