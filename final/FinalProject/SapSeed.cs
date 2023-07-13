
namespace final
{
    class SapSeed : Action
    {
        public SapSeed(string name, int damageToInstigater, int damageToReciver)
                : base(name, damageToInstigater, damageToReciver) { }

        public override string ApplyActions()
        {
            Charicter instigater = this.GetInstigater();
            Charicter reciver = this.GetReciver();

            // Get reciver and instigaters dammages 
            int damageToReciver = this.GetDamageToReciver();
            int damageToInstigater = this.GetDamageToInstigater();

            // Get instigater Health 
            int instigaterBaseHealth = instigater.GetBaseHealth();
            int instigaterCurretnHealth = instigater.GetCurrentHealth();

            // Check if enough power to activate
            if (instigater.GetPowerLevel() >= 2)
            {
                reciver.UpdateHealth(damageToReciver);
                instigater.UpdateHealth(damageToInstigater);

                return $"{instigater.GetName()} used SapSeed {damageToReciver} Dmg delt, {damageToInstigater} HP gained";

            }
            // If health is at max move will fail
            else if (instigaterCurretnHealth == instigaterBaseHealth)
            {
                return $"{instigater.GetName()}'s SeedBlitz failed already at max HP";

            }

            return $"{instigater.GetName()}'s SeedBlitz failed less then 2 power";
        }
    }
}