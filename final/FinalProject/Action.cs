
namespace final
{
    abstract class Action
    {
        public Charicter _instigater;
        public Charicter _reciver;
        public Action(Charicter instigater, Charicter reciver)
        {
            _instigater = instigater;
            _reciver = reciver;
        }

        public abstract void ApplyActions();
        // Maybe overload for diffrent actions - not nailed down yet...
    }
}