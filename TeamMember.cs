namespace HeistConsole;

/*
 * Class members
 * - fields
 *   - private string name;
 *   - a variable that exists in the scope of the class
 * - properties
 *   - public string Name {get; set;}
 *   - Properties are methods on a class that are accessed as if they were fields on that class.
 *   - User.Name
 * - methods
 *   - Methods define the actions that a class can perform (function)
 * - constructor
 *   - a method with the same name as a class that defines what should happen when that class is instantiated
 *   - methods that are called when the object is first created. They are often used to initialize the data of an object.
 */

public class TeamMember
{
    //overladed constructor
    //overload - same name, different signature
    public TeamMember()
    {

    }

    public TeamMember(string name, int skill, decimal courage)
    {
        Name = name;
        SkillLevel = skill;
        CourageFactor = courage;
    }

    public string Name { get; set; }

    private int _skill; //best practice - fields start with underscore
    public int SkillLevel
    {
        get => _skill;

        set
        {
            if (IsValidSkillLevel(value))
            {
                _skill = value;
            }
            else
            {
                throw new Exception("The skill level must be a positive number.");
            }
        }
    } // should be positive
    public decimal CourageFactor { get; set; }  //should be between 0.0 and 2.0
    //TeamMember.CourageFactor
    private bool IsValidSkillLevel(int skillLevel)
    {
        //List<string> collection = new List<string>();
        ////syntactic sugar - fancier/easier syntax for doing something that could already be done
        //foreach (var item in collection)
        //{
        //    item.ToUpper();
        //}

        //collection
        //    .Select(item => item.ToUpper())
        //    .Where(item => item.StartsWith("a"))
        //    .First();


        return skillLevel >= 0;
    }

    public override string ToString()
    {
        return @$"
====================
Name: {Name}
Skill: {SkillLevel}
Courage: {CourageFactor}
====================
";
    }




}

