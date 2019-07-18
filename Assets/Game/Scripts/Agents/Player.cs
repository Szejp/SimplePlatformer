using Game.Scripts.Commands;
using Game.Scripts.Commands.CommandSystem;

namespace Game.Scripts.Agents
{
    public class Player : Entity
    {
        public override void Kill()
        {
            gameObject.SetActive(false);
            CommandManager.Fire(new OnPlayerDiedCommand(this));
        }
    }
}