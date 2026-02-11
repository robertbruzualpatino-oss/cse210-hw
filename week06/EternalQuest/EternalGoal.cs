public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points) { }

    public override void RecordEvent(ref int score)
    {
        score += _points;
        Console.WriteLine($"¡Congratulations! You have won {_points} points.");
    }

    public override bool IsComplete() => false;

    public override string GetStringRepresentation() => $"EternalGoal:{_shortName},{_description},{_points}";
}