
namespace final
{
    abstract class FIreBall : Action
    {
        public FIreBall(Charicter instigater, Charicter reciver)
                : base(instigater, reciver)
        {

        }

        public override void ApplyActions()
        {
            this._reciver.UpdateHealth(-20);
        }
    }
}