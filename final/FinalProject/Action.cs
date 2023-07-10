
namespace final
{
    abstract class Action
    {
        private string _name;
        private int _damageToInstigater;
        private int _damageToReciver;

        public Action(string name, int damageToInstigater, int damageToReciver)
        {
            _damageToInstigater = damageToInstigater;
            _damageToReciver = damageToReciver;
            _name = name;
        }

        public abstract string ApplyActions(Charicter instigater, Charicter reciver);
        /*========================================================*\
        || This is the abstract for all actions.                  ||
        ||                                                        ||
        || Paramiters:                                            ||
        ||      instigater: 
        ||      reciver: 
        \*========================================================*/
        // TODOs Maybe overload for diffrent actions - not nailed down 
        //      yet...
        // TODOs Figure out some way to print the details of the move 
        //      during the battle

        public int GetDamageToInstgater()
        {
            return _damageToInstigater;
        }

        public int GetDamageToReciver()
        {
            return _damageToReciver;
        }

        public string GetName()
        {
            return _name;
        }
    }
}