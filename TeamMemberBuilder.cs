namespace HeistConsole;

//the job of this class is to handle collecting info and creating new team members
public class TeamMemberBuilder
{
    public TeamMember Run()
    {
        /*  Phase 2
         *  1. Create a way to store several team members.
         *     -loop our TeamMemberBuilder
            2. Collect several team members' information.
                - Team class?  List<TeamMember>
            3. Stop collecting team members when a blank name is entered.
            4. Display a message containing the number of members of the team.
            5. Display each team member's information.
*/

        // Part 1


        //TeamMember teamMember = new TeamMember("Superman", 1_000_000, 2.0m);
        //Console.WriteLine(teamMember);

        TeamMember teamMember = new TeamMember();

        Console.WriteLine("Enter name (leave blank to exit): ");
        teamMember.Name = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(teamMember.Name))
        {
            //they want to leave, return blank member
            return teamMember;
        }

        int skillAsInt;
        bool isInt;

        do
        {
            Console.WriteLine("Enter skill level: ");
            string skillInput = Console.ReadLine();
            isInt = int.TryParse(skillInput, out skillAsInt); //"-1", -1
            try
            {
                teamMember.SkillLevel = skillAsInt;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        } while (!isInt);

        string courageInput;
        bool userInputWasANumber;
        decimal courageAsDec;

        do
        {
            string name = "";
            Console.WriteLine("Enter courage factor (0.0 - 2.0): ");
            courageInput = Console.ReadLine();
            userInputWasANumber = decimal.TryParse(courageInput, out courageAsDec);
            teamMember.CourageFactor = courageAsDec;
        } while (!userInputWasANumber || courageAsDec < 0m || courageAsDec > 2m);

        return teamMember;
    }
}