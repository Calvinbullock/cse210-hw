using System.Collections.Generic;
using System;

namespace final
{
    class Charicter
    {
        private string _charicterName;
        private string _charicterDescription;
        private int _basePowerLevel;
        private int _baseHealthLevel;
        private int _baseAttackSpeed;
        private int _currentPowerLevel;
        private int _currentHealthLevel;
        private int _currentAttackSpeed;

        // TODO read to this from a file on instanciation
        private List<Action> _avalableActions = new List<Action>();

        public Charicter(string charicterName, string charicterDescription, int powerLevel, int healthLevel, int attackSpeed)
        {
            // Set base stats
            _charicterName = charicterName;
            _charicterDescription = charicterDescription;
            _basePowerLevel = powerLevel;
            _baseHealthLevel = healthLevel;
            _baseAttackSpeed = attackSpeed;

            // Set all current stats to base 
            _currentPowerLevel = _basePowerLevel;
            _currentHealthLevel = _baseHealthLevel;
            _currentAttackSpeed = _baseAttackSpeed;


            // --------- player diffrent charicter info class instantiation --------- \\
            // TODO move this to be read from a file in the future
            FireBall fireBall = new FireBall("FireBall", 0, -20);
            Defend defend = new Defend("Defend", 20, 0);

            _avalableActions = new List<Action>
            {
                fireBall,
                defend
            };            
        }

        public void UpdateHealth(int healthUpdate)
        {
            /*========================================================*\
            || Adds or subtracts healthUpdate from                    ||
            ||      _currentHealthLevel.                              ||
            ||                                                        ||
            || Paramiters:                                            ||
            ||      powerUpdate: A negative or positive number, that  ||
            ||                   indicats how much to ad or subtract  ||
            ||                   from poerLevel                       ||
            ||                                                        ||
            \*========================================================*/

            _currentHealthLevel += healthUpdate;
        }

        public void UpdateAttack(int speedUpdate)
        {
            /*========================================================*\
            || Adds or subtracts powerUpdate from _powerLevel.        ||
            ||                                                        ||
            || Paramiters:                                            ||
            ||      powerUpdate: A negative or positive number, that  ||
            ||                   indicats how much to ad or subtract  ||
            ||                   from poerLevel                       ||
            ||                                                        ||
            \*========================================================*/

            _currentAttackSpeed += speedUpdate;
        }

        public void UpdatePower(int powerUpdate)
        {
            /*========================================================*\
            || Adds or subtracts powerUpdate from _powerLevel.        ||
            ||                                                        ||
            || Paramiters:                                            ||
            ||      powerUpdate: A negative or positive number, that  ||
            ||                   indicats how much to ad or subtract  ||
            ||                   from poerLevel                       ||
            ||                                                        ||
            \*========================================================*/

            _currentPowerLevel += powerUpdate;
        }

        public void AddActionToAvalableActions(Action action)
        {
            _avalableActions.Add(action);
        }

        public List<Action> GetAvalableActions()
        {
            return _avalableActions;
        }

        public string GetName()
        {
            return _charicterName;
        }

        public string GetCharicterSummery()
        {
            return _charicterDescription;
        }
    }
}