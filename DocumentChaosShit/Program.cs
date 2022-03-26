// See https
using Newtonsoft.Json;

CreateAndWriteToFile();

ReadTheFile();




List<string> ItemList = new List<string> { "Honor Leapstone", "Great Honor Leapstone", "Honor Shard Pouch", "Solar Grace", "Solar Blessing", "Solar Protection", 
                                                "Destruction Stone Crystal", "Guardian Stone Crystal", "Powder of Sage"};




void ReadTheFile()
{
    List<ChaosBuy> ListOfChaosBuy = new List<ChaosBuy>();


    string filepath = Path.Combine(System.IO.Path.GetFullPath(@"..\..\"), "ChaosDocument.txt");


    var jsonString = File.ReadAllText(filepath);

    ListOfChaosBuy = JsonConvert.DeserializeObject<List<ChaosBuy>>(jsonString);

}

 void CreateAndWriteToFile()
{
    string filepath = Path.Combine(System.IO.Path.GetFullPath(@"..\..\"), "ChaosDocument.txt");
    List<ChaosBuy> ListOfChaosBuy = new List<ChaosBuy>();

    ChaosBuy newAdd = new ChaosBuy
    {
        ID = 1,
        ItemName = "blabla",
        ShardCost = 19
    };

    ListOfChaosBuy.Add(newAdd);

    string json = System.Text.Json.JsonSerializer.Serialize(ListOfChaosBuy);
    File.WriteAllText(filepath, json);
}



public class ChaosBuy
{
    public int ID { get; set; }
    public string ItemName { get; set; }
    public int ShardCost { get; set; }
}


