using Game.Scripts.Commands.CommandSystem;
using Game.Scripts.Commands.GameCommands;
using UnityEngine;
using UnityEngine.UI;

namespace Game.Scripts.UserInterface.Panels
{
    public class GameOverPanel : PanelBase
    {
        [SerializeField] Button restartButton;

        protected override void Awake()
        {
            base.Awake();
            restartButton.onClick.AddListener(OnRestartHandler);
        }

        void OnDestroy()
        {
            restartButton.onClick.AddListener(OnRestartHandler);
        }

        void OnRestartHandler()
        {
            CommandManager.Fire(new OnRestartGameCommand(Game.Player, Game.GameSettings));
            Deactivate();
        }
    }
}