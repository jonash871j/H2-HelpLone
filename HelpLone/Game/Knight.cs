namespace HelpLone.Game
{
    public class Knight : Character, IFighter, IUseShield
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

        public string RaiseShield()
        {
            return "I'm raising my shield";
        }

        public string ShieldGlare()
        {
            return "I'm throwing shield glare";
        }
    }
}
