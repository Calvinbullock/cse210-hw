
namespace final
{
    class Defend : Action
    {
        public Defend(string name, int damageToInstigater, int damageToReciver)
                : base(name, damageToInstigater, damageToReciver)
        {

        }

        public override string ApplyActions()
        {
            this.GetInstigater().UpdateHealth(this.GetDamageToInstgater());
            return $"{GetInstigater().GetName()} used Defend, 20 Dmg negated";
        }
    }
}