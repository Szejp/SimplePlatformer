using Game.Scripts.Commands.CommandSystem;

namespace Game.Scripts.Commands.GameCommands
{
    public struct OnFinishGameCommand : ICommand
    {
        public void Execute()
        {
            Game.UI.ShowGameOver();
        }
    }
}