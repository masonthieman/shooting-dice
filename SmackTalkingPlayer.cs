using System;
namespace ShootingDice
{
    // TODO: Complete this class

    // A Player who shouts a taunt every time they roll dice
    public class SmackTalkingPlayer : Player
    {
        public string Taunt { get; } = "Your bad at dice!";

        public override int Roll()
        {
            Console.WriteLine(Taunt);
            return base.Roll();
        }
    }
}