using Godot;

namespace Service
{
    // service for handling currency transacations in TEFG
    public partial class CurrencyService: Resource
    {
        [Export]
        public int Balance {get; set;} // the player's current balance

        // add to players currency balance
        public void Add(int amount)
        {
            this.Balance += amount;
        }

        
    }   
}