using Game.Scripts.Commands.CommandSystem;
using Game.Scripts.Commands.GameCommands;
using UnityEngine;

namespace Game.Scripts.Agents
{
    public class Player : Entity
    {
        protected override void OnKilled()
        {
            gameObject.SetActive(false);
            CommandManager.Fire(new OnPlayerDiedCommand(this, gameData));
            Debug.Log("[Player] kill");
        }

        void Update()
        {
            PlayerBelowGameLevelCheck();
        }

        void PlayerBelowGameLevelCheck()
        {
            if(transform.position.y < gameData.Settings.GameMinPosition)
                Kill();
        }
    }
}