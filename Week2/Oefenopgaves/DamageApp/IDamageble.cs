using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DamageApp {
    interface IDamageble {
        void OnDeath();
        bool TakeDamage(IDamager damager);
    }
}
