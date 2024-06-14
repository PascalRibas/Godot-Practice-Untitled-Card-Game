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
}