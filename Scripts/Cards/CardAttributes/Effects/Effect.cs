using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MatchNecessities;

namespace Effects
{
    public interface Effect
    {
        public void ApplyEffect(Player player);
    }

    //this doesn't really work, TODO find a better way of carrying over values (or just do it with custom effects)
    interface EffectWithIntValue
    {
        public void ApplyEffect(Player player, int amount);
    }
}