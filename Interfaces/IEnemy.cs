using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace turn_based_RPG.Interfaces
{
    public interface IEnemy
    {
        public Element weaknessElement { get; }
        public void Attack();
    }
}
