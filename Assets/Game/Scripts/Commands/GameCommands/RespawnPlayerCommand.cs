using Game.Scripts.Agents;
using Game.Scripts.Commands.CommandSystem;
using UnityEngine;

namespace Game.Scripts.Commands.GameCommands
{
    public struct RespawnPlayerCommand : ICommand
    {
        readonly Entity playerEntity;
        readonly Vector3 playerStartingPosition;

        public RespawnPlayerCommand(Entity playerEntity, Vector3 playerStartingPosition)
        {
            this.playerEntity = playerEntity;
            this.playerStartingPosition = playerStartingPosition;
        }

        public void Execute()
        {
            MovePlayer();
            playerEntity.gameObject.SetActive(true);
            playerEntity.Refresh();
        }

        void MovePlayer()
        {
            var rigidBody = playerEntity.GetComponent<Rigidbody2D>();
            rigidBody.Sleep();
            rigidBody.position = playerStartingPosition;
            playerEntity.transform.position = playerStartingPosition;
            rigidBody.WakeUp();
        }
    }
}