
namespace final
{
    abstract class FireBall : Action
    {
        public FireBall(int damageToInstigater, int damageToReciver)
                : base(damageToInstigater, damageToReciver)
        {

        }

        public override string ApplyActions(Charicter instigater, Charicter reciver)
        {
            instigater.UpdateHealth(this.GetDamageToReciver());
            return $"{instigater.GetName()} used FireBall 20 Dmg delt";
        }
    }
}