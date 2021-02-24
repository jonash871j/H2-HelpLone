
namespace HelpLone.Game
{
    public class Babarian : Character, IFighter
    {
        public string Bash()
        {
            return "I'm bashing someone";
        }

        public string Cleave()
        {
            return "I'm cleaving someone";
        }

        public string Slash()
        {
            return "I'm slashing someone";
        }
    }
}
