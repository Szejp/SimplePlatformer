using System;

namespace Game.Scripts.Data
{
    public class PlayerData
    {
        int livesCount = 3;

        public event Action<int> OnLivesChanged;

        public int LivesCount
        {
            get { return livesCount; }
            set
            {
                var cachedLivesValue = livesCount;
                livesCount = value;
                
                if (cachedLivesValue != value)
                    OnLivesChanged?.Invoke(value);
            }
        }
    }
}