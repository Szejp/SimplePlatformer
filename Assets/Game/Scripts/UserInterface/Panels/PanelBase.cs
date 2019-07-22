using UnityEngine;

namespace Game.Scripts.UserInterface.Panels
{
    public class PanelBase : MonoBehaviour
    {
        [SerializeField] View view;

        protected virtual void Awake()
        {
            view.Hide();
        }
        
        public void Activate()
        {
            view.Show();
        }

        public void Deactivate()
        {
            view.Hide();
        }
    }
}