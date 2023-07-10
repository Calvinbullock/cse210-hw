
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

        public Charicter(string charicterName, string charicterDescription, int powerLevel, int healthLevel, int attackSpeed)
        {
            _charicterName = charicterName;
            _charicterDescription = charicterDescription;
            _basePowerLevel = powerLevel;
            _baseHealthLevel = healthLevel;
            _baseAttackSpeed = attackSpeed;


            _currentPowerLevel = _basePowerLevel;
            _currentHealthLevel = _baseHealthLevel;
            _currentAttackSpeed = _baseAttackSpeed;
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

            _currentHealthLevel = healthUpdate;
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

            _currentAttackSpeed = speedUpdate;
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

            _currentPowerLevel = powerUpdate;
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