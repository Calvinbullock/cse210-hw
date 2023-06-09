
namespace final
{
    class FireBall : Action
    {
        public FireBall(string name, int damageToInstigater, int damageToReciver)
                : base(name, damageToInstigater, damageToReciver) { }

        public override string ApplyActions()
        {
            Charicter instigater = this.GetInstigater();
            Charicter reciver = this.GetReciver();

            int damageToReciver = this.GetDamageToReciver();

            reciver.UpdateHealth(damageToReciver);
            return $"{instigater.GetName()} used FireBall {damageToReciver} Dmg delt";
        }
    }
}