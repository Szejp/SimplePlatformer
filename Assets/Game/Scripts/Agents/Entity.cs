using Game.Scripts.Agents.Configs;
using Game.Scripts.Data;
using UnityEngine;

namespace Game.Scripts.Agents
{
    public abstract class Entity : MonoBehaviour
    {
        protected GameData gameData;
        
        CollisionManager collisionManager;
        EntityConfig config;

        public bool IsAlive { get; private set; } = true;

        public void Kill()
        {
            if (IsAlive)
            {
                IsAlive = false;
                OnKilled();
            }
        }

        public void Refresh()
        {
            IsAlive = true;
        }

        public void SetCollisionManager(CollisionManager collisionManager)
        {
            this.collisionManager = collisionManager;
        }

        public void SetGameData(GameData gameData)
        {
            this.gameData = gameData;
        }

        public void SetConfig(EntityConfig config)
        {
            this.config = config;
        }

        protected virtual void OnCollisionEnter2D(Collision2D other)
        {
            if (!IsAlive)
                return;
            
            var otherEntity = other.collider.GetComponent<Entity>();
            if (otherEntity)
                collisionManager.HandleCollision(this, otherEntity);
        }

        protected abstract void OnKilled();
    }
}