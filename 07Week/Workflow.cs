using System;
using System.Collections.Generic;

public class Program
{

    // Fields
    private static Engine _engine;
    private static Workflow _workflow;

    //Properties
    //

    //Constructor
    static Program()
    {
        _engine = new Engine();
        _workflow = new Workflow();
    }

    //Methods
    public static void Main()
    {
        _engine.Run(_workflow);

        Console.ReadLine();
    }

}

public class Engine
{
    //Fields
    //Properties
    //Constructors
    //Methods
    public void Run(Workflow workflow)
    {
        foreach (var activity in workflow.Activities)
        {
            activity.Execute();
        }
    }
}

public class Workflow
{
    //Fields
    //Properties
    public List<IActivity> Activities { get; set; }

    //Constructors
    public Workflow()
    {

        //Old way of adding items to list
        //Activities = new List<Activity>();
        //Activities.Add(new Activity());
        //Activities.Add(new Activity());
        //Activities.Add(new Activity());
        //Activities.Add(new Activity());


        //New syntax of adding items to list, based on constructors
        Activities = new List<IActivity>()
        {
            {new SportActivity() {Message = "Running"} },
            {new SportActivity() {Message = "Batting"} },
            {new SportActivity() {Message = "Kicking"} },
            {new SportActivity() {Message = "Dribbling"} },
        };

    }
    //Methods
}

public class SportActivity : IActivity
{
    //Fields
    //Properties
    public string Message { get; set; }

    //Constructors
    //public SportActivity(string message);
    //{
    //Message = message;
    //}

    //Methods
    public void Execute()
    {
        Console.WriteLine(Message);
    }
}


public class OutdoorActivity
{

}


public interface IActivity
{
    // Properties
    string Message { get; set; }

    // Methods
    void Execute();

}