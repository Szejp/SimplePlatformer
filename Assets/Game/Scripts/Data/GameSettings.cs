using UnityEngine;

namespace Game.Scripts.Data
{
    [System.Serializable]
    public class GameSettings
    {
        [SerializeField] int gameMinPosition = -6;
        [SerializeField] int playerLivesCount = 3;
        [SerializeField] Vector3 playerStartingPosition = new Vector3(-6, 0, 0);

        public int GameMinPosition => gameMinPosition;
        public int PlayerLivesCount => playerLivesCount;
        public Vector3 PlayerStartingPosition => playerStartingPosition;
    }
}