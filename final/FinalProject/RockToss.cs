
namespace final
{
    class RockToss : Action
    {
        public RockToss(string name, int damageToInstigater, int damageToReciver)
                : base(name, damageToInstigater, damageToReciver) { }

        public override string ApplyActions()
        {
            Charicter instigater = this.GetInstigater();
            Charicter reciver = this.GetReciver();

            int damageToReciver = this.GetDamageToReciver();

            reciver.UpdateHealth(damageToReciver);
            return $"{instigater.GetName()} used RockToss {damageToReciver} Dmg delt";
        }
    }
}