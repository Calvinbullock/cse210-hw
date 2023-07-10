
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

        public override string ApplyActions(Charicter instigater, Charicter reciver)
        {
            /*========================================================*\
            || This is the abstract for all actions.                  ||
            ||                                                        ||
            || Paramiters:                                            ||
            ||      instigater: 
            ||      reciver: 
            \*========================================================*/
            instigater.UpdateHealth(this.GetDamageToReciver());
            return $"{instigater.GetName()} used FireBall 20 Dmg delt";
        }
    }
}