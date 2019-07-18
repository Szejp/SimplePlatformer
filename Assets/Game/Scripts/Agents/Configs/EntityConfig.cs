using UnityEngine;

namespace Game.Scripts.Agents.Configs
{
    [CreateAssetMenu(fileName = "EntityConfig", menuName = "Game/Config/EntityConfig")]
    public class EntityConfig : ScriptableObject
    {
        public GameObject destroyEffect;
    }
}