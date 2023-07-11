
namespace final
{
    class FireBall : Action
    {
        public FireBall(string name, int damageToInstigater, int damageToReciver)
                : base(name, damageToInstigater, damageToReciver)
        {
            /*========================================================*\
            || This is the abstract for all actions, posstive for     ||
            ||      adding health pos numbers, dealing damage         ||
            ||      negativs.                                         ||
            ||                                                        ||
            || Paramiters:                                            ||
            ||      damageToInstigater:                               ||
            ||      damageToReciver:                                  ||
            \*========================================================*/

        }

        public override string ApplyActions()
        {
            /*========================================================*\
            || This is the abstract for all actions.                  ||
            ||                                                        ||
            || Paramiters:                                            ||
            ||      instigater: 
            ||      reciver: 
            \*========================================================*/

            this.GetReciver().UpdateHealth(this.GetDamageToReciver());
            return $"{this.GetInstigater().GetName()} used FireBall 20 Dmg delt";
        }
    }
}