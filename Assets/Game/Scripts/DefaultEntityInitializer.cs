using Game.Scripts.Agents;
using Game.Scripts.Agents.Configs;
using UnityEngine;

namespace Game.Scripts {
    [RequireComponent(typeof(Entity))]
    public class DefaultEntityInitializer : MonoBehaviour
    {
        [SerializeField] EntityConfig config;

        void Awake()
        {
            var entity = GetComponent<Entity>();
            entity.SetCollisionManager(GameContext.CollisionManager);
        
            if (config != null)
                entity.SetConfig(config);
        }
    }
}