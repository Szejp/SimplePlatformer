using Game.Scripts.Agents;
using Game.Scripts.Commands.CommandSystem;
using Game.Scripts.Data;

namespace Game.Scripts.Commands.GameCommands
{
    public struct OnPlayerDiedCommand : ICommand
    {
        readonly Entity player;
        readonly GameData gameData;

        public OnPlayerDiedCommand(Entity player, GameData gameData)
        {
            this.player = player;
            this.gameData = gameData;
        }

        public void Execute()
        {
            player.gameObject.SetActive(false);
            gameData.Player.LivesCount--;

            if (gameData.Player.LivesCount > 0)
                RespawnPlayerOnDeath();
            else
                CommandManager.Fire<OnFinishGameCommand>();
        }

        void RespawnPlayerOnDeath()
        {
            CommandManager.Fire(new RespawnPlayerCommand(player, gameData.Settings.PlayerStartingPosition));
        }
    }
}