using System.Collections.Generic;

namespace final
{
    class Turn
    {
        /*========================================================*\
        || This class stores all the actions selected in a turn   ||
        ||      and applies them when the turn ends.              ||
        ||                                                        ||
        \*========================================================*/

        // TODO Need to make a way for diffrent actions to interact 
        //      with other actions 

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
            || Return:                                                ||
            ||        A list of sumemry actions that let the players  ||
            ||          know the outcome of the actions.              ||
            ||                                                        ||
            \*========================================================*/

            List<string> actionSummerys = new List<string>();

            // loops through all actions to apply them.
            foreach (Action action in _choosenActions)
            {
                actionSummerys.Add(action.ApplyActions());
            }

            // Clear the list for next turn
            _choosenActions.Clear();

            return actionSummerys;
        }

    }
}