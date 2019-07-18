using Game.Scripts.Agents;

namespace Game.Scripts
{
    public class CollisionManager
    {
        public void HandleCollision(Entity colllided, Entity collidedWith)
        {
            if (TryGetType(colllided, out Player player))
                HandlePlayerCollision(player, collidedWith);
        }

        void HandlePlayerCollision(Player player, Entity collidedWith)
        {
            if (TryGetType(collidedWith, out Obstacle obstacle))
                player.Kill();
        }

        bool TryGetType<T>(Entity entity, out T result) where T : Entity
        {
            result = entity as T;
            return result != null;
        }
    }
}