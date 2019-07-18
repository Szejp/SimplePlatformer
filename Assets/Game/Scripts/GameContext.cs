using UnityEngine;

namespace Game.Scripts
{
    public class GameContext : MonoBehaviour
    {
        public static GameContext Instance;
        
        public static CollisionManager CollisionManager => Instance.collisionManager;

        CollisionManager collisionManager;

        void Awake()
        {
            Instance = this;
            
            collisionManager = new CollisionManager();
        }
    }
}