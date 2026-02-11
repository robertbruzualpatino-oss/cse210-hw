public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus, int current = 0) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = current;
    }

    public override void RecordEvent(ref int score)
    {
        _amountCompleted++;
        score += _points;

        if (_amountCompleted == _target)
        {
            score += _bonus;
            Console.WriteLine($"¡Bonus achieved! You won {_points + _bonus} points.");
        }
    }

    public override bool IsComplete() => _amountCompleted >= _target;

    public override string GetDetailsString()
    {
        return base.GetDetailsString() + $" -- Currently completed: {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation() => $"ChecklistGoal:{_shortName},{_description},{_points},{_bonus},{_target},{_amountCompleted}";
}