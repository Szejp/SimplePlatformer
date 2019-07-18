using Game.Scripts.Agents.Configs;
using UnityEngine;

namespace Game.Scripts.Agents
{
    public abstract class Entity : MonoBehaviour
    {
        CollisionManager collisionManager;
        EntityConfig config;

        public abstract void Kill();

        public void SetCollisionManager(CollisionManager collisionManager)
        {
            this.collisionManager = collisionManager;
        }

        public void SetConfig(EntityConfig config)
        {
            this.config = config;
        }

        protected virtual void OnCollisionEnter2D(Collision2D other)
        {
            var otherEntity = other.collider.GetComponent<Entity>();
            if (otherEntity)
                collisionManager.HandleCollision(this, otherEntity);
        }
    }
}