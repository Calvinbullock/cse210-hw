
namespace final
{
    abstract class Defend : Action
    {
        public Defend(int damageToInstigater, int damageToReciver)
                : base(damageToInstigater, damageToReciver)
        {

        }

        public override string ApplyActions(Charicter instigater, Charicter reciver)
        {
            instigater.UpdateHealth(this.GetDamageToReciver());
            return $"{instigater.GetName()} used Defend, 20 Dmg negated";
        }
    }
}