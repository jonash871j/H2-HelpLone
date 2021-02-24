namespace HelpLone.Game
{
    public class Witch : Character, IUseShield, ITeleport
    {
        public string RaiseShield()
        {
            return "I'm raising my shield";
        }

        public string ShieldGlare()
        {
            return "I'm throwing shield glare";
        }

        public string Teleport(int x, int y)
        {
            return "I'm teleporting to " + x + " " + y;
        }
    }
}
