
namespace final
{
    class Defend : Action
    {
        public Defend(string name, int damageToInstigater, int damageToReciver)
                : base(name, damageToInstigater, damageToReciver) { }

        public override string ApplyActions()
        {
            Charicter instigater = this.GetInstigater();
            Charicter reciver = this.GetReciver();

            // Get instigater / recivers damage
            int damageToReciver = this.GetDamageToReciver();
            int damageToInstigater = this.GetDamageToInstigater();

            instigater.UpdateHealth(damageToInstigater);
            return $"{instigater.GetName()} used Defend, {damageToInstigater} Dmg negated";
        }
    }
}