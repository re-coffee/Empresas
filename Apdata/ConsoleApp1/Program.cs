var list = new Dictionary<string, List<string>>()

    {

    {"one", new List<string> {"1","2","3"}},
        {"two", new List<string> {"1","2","3"}},
    {"three", new List<string> {"1","2","3"}},
        {"four", new List<string> {"1","2","3"}}
};


var res = list.SelectMany(d => d.Value).Select(x => new {Database = x});

foreach (var val in res)
    Console.WriteLine(val);

Console.ReadLine();