using System.Collections.Generic;

namespace final
{
    class Turn
    {
        private List<Action> _choosenActions = new List<Action>();

        public void Add(Action action)
        {
            _choosenActions.Add(action);
        }

        public void EndTurn()
        {
            /*========================================================*\
            || Applys all action made in the turn.                    ||
            ||                                                        ||
            \*========================================================*/
            foreach (Action action in _choosenActions)
            {
                action.ApplyActions();
            }
        }

    }
}