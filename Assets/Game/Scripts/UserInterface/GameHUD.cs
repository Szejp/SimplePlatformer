using Game.Scripts.Data;
using TMPro;
using UnityEngine;

namespace Game.Scripts.UserInterface
{
    public class GameHUD : MonoBehaviour
    {
        const string LIVES_TEXT = "Lives: {0}";

        PlayerData playerData;

        [SerializeField] TextMeshProUGUI livesText;

        public void Initialize()
        {
            playerData = Game.Data.Player;
            playerData.OnLivesChanged += RefreshLives;
        }

        void OnDestroy()
        {
            playerData.OnLivesChanged -= RefreshLives;
        }

        void OnEnable()
        {
            RefreshLives(playerData.LivesCount);
        }

        void RefreshLives(int livesCount)
        {
            livesText.text = string.Format(LIVES_TEXT, livesCount.ToString());
        }
    }
}