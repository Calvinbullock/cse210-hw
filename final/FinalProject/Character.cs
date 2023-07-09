
namespace final
{
    class Charicter
    {
        private string _charicterName;
        private string _charicterDescription;
        private int _powerLevel;
        private int _healthLevel;
        private int _attackSpeed;

        public Charicter(string charicterName, string charicterDescription, int powerLevel, int healthLevel, int attackSpeed)
        {
            _charicterName = charicterName;
            _charicterDescription = charicterDescription;
            _powerLevel = powerLevel;
            _healthLevel = healthLevel;
            _attackSpeed = attackSpeed;
        }

        public void UpdateHealth(int damage) { }
        public void UpdatePower(int powerUpdate) { }

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