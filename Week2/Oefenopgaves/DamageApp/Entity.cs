using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DamageApp {
    class Entity : MonoBehavior {
        int health;

        public virtual int Health {
            get => health;
            set => health = value;
        }

        public virtual void Die() {

        }
    }
}
