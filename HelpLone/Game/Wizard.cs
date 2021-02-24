namespace HelpLone.Game
{
    public class Wizard : Character, IThrowMagicSpell, ITeleport
    {
        public string Teleport(int x, int y)
        {
            return "I'm teleporting to " + x + " " + y;
        }

        public string ThrowFrostNova()
        {
            return "I'm throwing my frost nova";
        }

        public string ThrowMagicMisile()
        {
            return "I'm throwing a magic misile";
        }
    }
}
