foreach (var arg in args)
{
    try
    {
        Type type = Type.GetType($"ApTask.{arg}", false, false);
        object oClass = Activator.CreateInstance(type);
    }
    catch { continue; }
}


//new Update();
//new Show();
//new Rerun();
//new Force();
//new Update();
//new SendMail();