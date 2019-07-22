using Game.Scripts.Agents;
using Game.Scripts.Commands.CommandSystem;
using Game.Scripts.Data;

namespace Game.Scripts.Commands.GameCommands
{
    public struct OnRestartGameCommand : ICommand
    {
        readonly Entity player;
        readonly GameSettings gameSettings;

        public OnRestartGameCommand(Entity player, GameSettings gameSettings)
        {
            this.player = player;
            this.gameSettings = gameSettings;
        }
        
        public void Execute()
        {
            Game.Data.Player.LivesCount = gameSettings.PlayerLivesCount;
            CommandManager.Fire(new RespawnPlayerCommand(player, gameSettings.PlayerStartingPosition));
        }
    }
}