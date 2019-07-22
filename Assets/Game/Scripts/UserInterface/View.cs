using UnityEngine;

namespace Game.Scripts.UserInterface
{
    public abstract class View : MonoBehaviour
    {
        public abstract void Show();
        public abstract void Hide();
    }
}