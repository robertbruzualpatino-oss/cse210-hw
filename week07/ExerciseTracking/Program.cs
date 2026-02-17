using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        activities.Add(new Running("03/15/2024", 30, 5.0));
        activities.Add(new Cycling("03/16/2024", 60, 20.0));
        activities.Add(new Swimming("03/17/2024", 45, 30));

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}