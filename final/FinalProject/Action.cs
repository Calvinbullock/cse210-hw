
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

        public abstract string ApplyActions();
        // TODOs Maybe overload for diffrent actions - not nailed down 
        //      yet...
        // TODOs Figure out some way to printthe details of the move 
        //      during the battle
    }
}