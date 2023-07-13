using System.Collections.Generic;

namespace final
{
    class Charicter
    {
        /*========================================================*\
        || This class is the base for charicters and there stats. ||
        ||        This class also stores the avalable moves for   ||
        ||        each charicter.                                 ||
        ||                                                        ||
        \*========================================================*/

        // TODO move Action instatiations to be read from a file in the future
        // TODO add fileName to constructer paramiters. That will let move sets 
        //      be diffrent for diffrent charicters. 

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

            // --------- Action instatiations --------- \\
            FireBall fireBall = new FireBall("FireBall", 0, -20);
            RockToss rockToss = new RockToss("RockToss", 0, -20);
            AirSlice airSlice = new AirSlice("AirSlice", 10, -10);
            SapSeed sapSeed = new SapSeed("SapSeed", 10, -20);

            Defend defend = new Defend("Defend", 20, 0);

            _avalableActions = new List<Action>
            {
                fireBall,
                defend,
                airSlice,
                rockToss,
                sapSeed
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

        public int GetCurrentHealth()
        {
            return _currentHealthLevel;
        }

        public int GetBaseHealth()
        {
            return _baseHealthLevel;
        }

        public int GetCurrentPowerLevel()
        {
            return _currentPowerLevel;
        }

        public int GetBasePowerLevel()
        {
            return _basePowerLevel;
        }

    }
}