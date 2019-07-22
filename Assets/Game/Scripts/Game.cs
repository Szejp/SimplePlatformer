using Game.Scripts.Agents;
using Game.Scripts.Configs;
using Game.Scripts.Data;
using Game.Scripts.UserInterface;
using UnityEngine;

namespace Game.Scripts
{
    public class Game : MonoBehaviour
    {
        [Header("UI")]
        [SerializeField] UI ui;
        
        [Header("Player")]
        [SerializeField] Player player;

        [Header("Configs")] 
        [SerializeField] GameConfig gameConfig;
        
        static Game Instance;

        public static CollisionManager CollisionManager { get; private set; }
        public static GameData Data { get; private set; }
        public static UI UI => Instance.ui;
        public static GameSettings GameSettings => Instance.gameConfig.settings;
        public static Player Player => Instance.player;
        

        void Awake()
        {
            Instance = this;

            Initialize();
        }

        void Initialize()
        {
            Data = new GameData(gameConfig.settings);
            CollisionManager = new CollisionManager();
            
            UI.Initialize();
        }
    }
}