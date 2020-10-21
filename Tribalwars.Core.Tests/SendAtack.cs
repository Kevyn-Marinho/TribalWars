using Microsoft.VisualStudio.TestTools.UnitTesting;
using TribalWars.Core.Interfaces.Services;
using TribalWars.Core.Model;
using TribalWars.Services;

namespace Tribalwars.Core.Tests
{
    [TestClass]
    public class SendAtack
    {
        [TestMethod]
        public void CreateNewVillage()
        {
            var village = new Village(new Troops());

            Assert.IsNotNull(village);
        }

        [TestMethod]
        public void SendAttack()
        {
            var attacker = new Village(new Troops());
            var defensor = new Village(new Troops());
            var troopsToGo = new Troops
            {
                Barbarians = 1000,
                LightCavalary = 1500,
                Rams = 190
            };

            IAttackService service = new AttackService();


            service.SendAttack(attacker, defensor);
        }

       public void TroopsToGoCantBeLessThen25AttackForce()
        {
            var attacker = new Village(new Troops());
            var defensor = new Village(new Troops());
            var troopsToGo = new Troops();

            IAttackService service = new AttackService();

            service.SendAttack(attacker, defensor);
        }
    }
}
