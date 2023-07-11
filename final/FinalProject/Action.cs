
namespace final
{
    abstract class Action
    {
        /*========================================================*\
        || This Class allows varies diffrent actions to be        ||
        ||      preformed on both the action instigater and the   ||
        ||      reciver of the action.                            ||
        ||                                                        ||
        \*========================================================*/

        private string _name;
        private int _damageToInstigater;
        private int _damageToReciver;

        private Charicter _instagator;
        private Charicter _reciver;

        public Action(string name, int damageToInstigater, int damageToReciver)
        {
            _damageToInstigater = damageToInstigater;
            _damageToReciver = damageToReciver;
            _name = name;
        }

        public abstract string ApplyActions();
        /*========================================================*\
        || This is the abstract for all actions. Updates health   ||
        ||      and other data that pertains to the given action. ||
        ||      by the diffrent actions.                          ||
        ||                                                        ||
        \*========================================================*/

        public int GetDamageToInstigater()
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

        public Charicter GetInstigater()
        {
            return _instagator;
        }

        public Charicter GetReciver()
        {
            return _reciver;
        }

        public void SetInstigaterAndReciver(Charicter instigater, Charicter reciver)
        {
            _instagator = instigater;
            _reciver = reciver;
        }
    }
}