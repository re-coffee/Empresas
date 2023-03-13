namespace ApTask
{
    public class Base
    {
        public Base()
        {
            foreach (var cfg in Ctx.Configurations.ToList())
                Cfgs.Add(cfg.Parameter.Trim(), cfg.Value.Trim());
            Go();
        }
        public Context Ctx { get; set; } = new Context();
        public Dictionary<string, string> Cfgs { get; set; } = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public List<Task> TaskList { get; set; } =
            new Context()
                    .Tasks
                    .Where(x => x.Status == "Ready" &&
                                x.LastResult != "0" &&
                                x.LastResult != "267009" &&
                                x.LastResult != "267011").ToList();
        public virtual void Go() { }
    }
}
