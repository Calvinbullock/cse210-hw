
namespace final
{
    abstract class FireBall : Action
    {
        public FireBall(Charicter instigater, Charicter reciver)
                : base(instigater, reciver)
        {

        }

        public override string ApplyActions()
        {
            this._reciver.UpdateHealth(-20);
            return $"{this._instigater.GetName()} used FireBall 20 Dmg delt";
        }
    }
}