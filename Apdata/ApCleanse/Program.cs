foreach (var arg in args)
{
    try
    {
        new ApCleanse.Class.Rotina(arg);
    }
    catch { continue; }

}