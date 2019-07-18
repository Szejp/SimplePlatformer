using Game.Scripts.Agents;
using Game.Scripts.Commands.CommandSystem;
using UnityEngine;

namespace Game.Scripts.Commands
{
    public class OnPlayerDiedCommand : ICommand
    {
        readonly Entity playerEntity;

        Vector3 playerStartingPosition = new Vector3(-6, 0, 0);

        public OnPlayerDiedCommand(Entity playerEntity)
        {
            this.playerEntity = playerEntity;
        }

        public void Execute()
        {
            playerEntity.transform.position = playerStartingPosition;
            playerEntity.gameObject.SetActive(true);
        }
    }
}