
namespace final
{
    abstract class Defend : Action
    {
        public Defend(Charicter instigater, Charicter reciver)
                : base(instigater, reciver)
        {

        }

        public override string ApplyActions()
        {
            this._instigater.UpdateHealth(20);
            return $"{this._instigater.GetName()} used Defend, 20 Dmg negated";
        }
    }
}