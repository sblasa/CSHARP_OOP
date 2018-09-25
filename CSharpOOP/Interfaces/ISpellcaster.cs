using Characters;
using Characters.Warriors;
using System;


namespace Interfaces
{
    public interface ISpellcaster
    {
        int Mana { get; set; }

        void CastSpell(Character character);
       
    }
}
