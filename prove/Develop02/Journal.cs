using System.IO;
class Journal


{
    List<Entry> entries;

    public Journal()
{
    entries = new List<Entry>();
}

public void DeployJournal()
{
    foreach (Entry entry in entries)
        {
        entry.DesployEntry();
        }
}
public void CreateJournal()
{
    string entry = "entry.txt";

    using (StreamWriter outputFile = new StreamWriter(entry))
        {
            // You can add text to the file with the WriteLine method
            outputFile.WriteLine();
        }

public void Save(List<Entry>entries)
{
    string filename = "entry.txt";

    using (StreamWriter outputFile = new StreamWriter(filename))

    foreach (Entry entry in entries)
    {
        outputFile.WriteLine();
    }
}

public void Load()
{

}
}
}

