using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CoolCast {
    public class Character : MonoBehaviour, IDamageble {
        public Character(float speed, int blastRadius) {
            lives = Options.Lives + lives;
            this.speed = speed;
            this.blastRadius = blastRadius;
        }

        private int lives;
        private float speed;
        private int blastRadius;
        

        public virtual void Shoot() {

        }

        public virtual void Move() {

        }

    }
}
