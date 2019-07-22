using Game.Scripts.UserInterface.Panels;
using UnityEngine;

namespace Game.Scripts.UserInterface
{
    public class UI : MonoBehaviour
    {
        [Header("GameHUD")] 
        [SerializeField] GameHUD gameHud;

        [Header("Panels")] 
        [SerializeField] GameOverPanel gameOverPanel;

        public void Initialize()
        {
            gameHud.Initialize();
        }

        public void ShowGameOver()
        {
            gameOverPanel.Activate();
        }
    }
}