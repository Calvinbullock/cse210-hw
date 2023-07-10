
namespace final
{
    abstract class Action
    {
        public Action(Charicter Instigater, Charicter Reciver) { }

        public abstract void ApplyActions();
        // Maybe overload for diffrent actions - not nailed down yet...
    }
}