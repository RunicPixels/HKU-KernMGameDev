using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CoolCast {
    public class Character : MonoBehaviour, IDamageble {
        public Character(float speed, int blastRadius) {
            Lives = Options.Lives + Lives;
            this.Speed = speed;
            this.BlastRadius = blastRadius;
        }

        private int lives;
        private float speed;
        private int blastRadius;

        public int Lives {
            get {
                return lives;
            }

            set {
                lives = value;
            }
        }

        public float Speed {
            get {
                return speed;
            }

            set {
                speed = value;
            }
        }

        public int BlastRadius {
            get {
                return blastRadius;
            }

            set {
                blastRadius = value;
            }
        }

        public virtual void Shoot() {

        }

        public virtual void Move() {

        }

    }
}
