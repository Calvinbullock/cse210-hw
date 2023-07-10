
namespace final
{
    class Defend : Action
    {
        public Defend(string name, int damageToInstigater, int damageToReciver)
                : base(name, damageToInstigater, damageToReciver)
        {

        }

        public override string ApplyActions(Charicter instigater, Charicter reciver)
        {
            instigater.UpdateHealth(this.GetDamageToReciver());
            return $"{instigater.GetName()} used Defend, 20 Dmg negated";
        }
    }
}