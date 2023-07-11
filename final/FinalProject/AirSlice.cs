
namespace final
{
    class AirSlice : Action
    {
        public AirSlice(string name, int damageToInstigater, int damageToReciver)
                : base(name, damageToInstigater, damageToReciver) { }

        public override string ApplyActions()
        {
            Charicter instigater = this.GetInstigater();
            Charicter reciver = this.GetReciver();

            // Get instigater / recivers damage
            int damageToReciver = this.GetDamageToReciver();
            int damageToInstgater = this.GetDamageToInstigater();

            // Deal damage 
            reciver.UpdateHealth(damageToReciver);

            // Deal health increase
            instigater.UpdateHealth(damageToInstgater);
            return $"{instigater.GetName()} used AirSlice {this.GetDamageToReciver()} Dmg delt, {damageToInstgater} Dmg negated";
        }
    }
}