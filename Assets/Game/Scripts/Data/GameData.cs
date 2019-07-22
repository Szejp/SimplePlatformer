namespace Game.Scripts.Data
{
    public class GameData
    {
        public PlayerData Player { get; }
        public GameSettings Settings { get; }

        public GameData(GameSettings settings)
        {
            Player = new PlayerData();
            Settings = settings;
        }
    }
}