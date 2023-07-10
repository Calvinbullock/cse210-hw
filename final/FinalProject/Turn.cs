using System.Collections.Generic;

namespace final
{
    class Turn
    {
        private List<Action> _choosenActions = new List<Action>();

        public void AddAction(Action action)
        {
            _choosenActions.Add(action);
        }

        public void EndTurn(Charicter instigater, Charicter reciver)
        {
            /*========================================================*\
            || Applys all action made in the turn.                    ||
            ||                                                        ||
            \*========================================================*/

            foreach (Action action in _choosenActions)
            {
                action.ApplyActions(instigater, reciver);
            }
        }

    }
}