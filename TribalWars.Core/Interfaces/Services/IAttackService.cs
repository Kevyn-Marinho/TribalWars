using TribalWars.Core.Model;

namespace TribalWars.Core.Interfaces.Services
{
    public interface IAttackService
    {
        void SendAttack(Village sender, Village receiver);
    }
}
