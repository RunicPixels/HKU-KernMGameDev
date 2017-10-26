using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CoolCast {

    public class Projectile : MonoBehaviour, IDamageble {
        private float velocity;
        private int blastRadius;
        private Character owner;

        // Direction is Clockwise (0 = UP, 1 = RIGHT, 2 = BOTTOM, 3 = LEFT)
        public Projectile(float velocity, int direction, int blastRadius, Character owner ) {

        }

        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }
    }
}
