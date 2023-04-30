using System.IO;
class Journal


{
    List<string> entries;

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
    string entry = "myFile.txt";

    using (StreamWriter outputFile = new StreamWriter(entry))
        {
            // You can add text to the file with the WriteLine method
            outputFile.WriteLine();
        }

public void Save()
{

}

public void Load()
{

}
}

