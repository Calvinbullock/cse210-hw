
namespace final
{
    abstract class Action
    {
        private int _damageToInstigater;
        private int _damageToReciver;

        public Action(int damageToInstigater, int damageToReciver)
        {
            _damageToInstigater = damageToInstigater;
            _damageToReciver = damageToReciver;
        }

        public abstract string ApplyActions(Charicter instigater, Charicter reciver);
        // TODOs Maybe overload for diffrent actions - not nailed down 
        //      yet...
        // TODOs Figure out some way to printthe details of the move 
        //      during the battle

        public int GetDamageToInstgater()
        {
            return _damageToInstigater;
        }
        public int GetDamageToReciver()
        {
            return _damageToReciver;
        }
    }
}