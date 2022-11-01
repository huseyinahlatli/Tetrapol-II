namespace Interfaces
{
    public interface IHealth
    {
        public int CurrentHealth { get; set; }
    
        public int MaxHealth { get; set; }

        public void SetHealth(int health);

        public void SetMaxHealth(int maxHealth);
    
        public void DealDamage(int amount);
    }
}


