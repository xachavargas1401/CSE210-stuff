class Goal
{
    private string _name;
    private string _description;
    private int _numberOfPoints;
    private bool _status;
    private string _goalType;
    
    public Goal(string name, string description)
    {
        _name = name;
        _description = description;
        _numberOfPoints = 0;
        _status = false;
        _goalType = "";
    }

    public virtual string GetConsoleString()
    {
        return $"Name: {_name}, Description: {_description}, Points: {_numberOfPoints}";
    }
    
}