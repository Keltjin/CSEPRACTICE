public class Resume
{
    public string Name;
    public List<Job> Jobs;

    public Resume()
    {
        this.Jobs = new List<Job>();
    }

    public void Display()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine("Jobs:");

        foreach (Job job in Jobs)
        {
            job.Display();
        }
    }
}