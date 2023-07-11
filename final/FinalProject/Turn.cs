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

        public List<string> EndTurn()
        {
            /*========================================================*\
            || Applys all action made in the turn.                    ||
            ||                                                        ||
            \*========================================================*/

            List<string> actionSummerys = new List<string>();

            foreach (Action action in _choosenActions)
            {
                actionSummerys.Add(action.ApplyActions());
            }
            return actionSummerys;
        }

    }
}