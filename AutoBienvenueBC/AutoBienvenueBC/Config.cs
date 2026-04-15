namespace AutoBienvenueBC
{
    public class Config
    {
        public bool Enabled { get; set; } = true;
        public bool Debug { get; set; } = false;
        public string welcomeMessage { get; set; } = "<b><color=#727472>Bienvenue sur <color=#4046F5>mon serveur</color> !</color>\n<size=20><color=#727472>N'oubliez pas de <color=#FFF663>faire un tour du règlement</color> et à <color=#FFF663>rejoindre notre Discord</color> !</color></size></b>\n";
        public ushort messageDuration { get; set; } = 10;
    }
}