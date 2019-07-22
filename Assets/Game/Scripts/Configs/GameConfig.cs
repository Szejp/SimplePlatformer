using Game.Scripts.Data;
using UnityEngine;

namespace Game.Scripts.Configs
{
    [CreateAssetMenu(fileName = "GameConfig", menuName = "Game/Config/GameConfig")]
    public class GameConfig : ScriptableObject
    {
        public GameSettings settings;
    }
}