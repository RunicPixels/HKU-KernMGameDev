using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

namespace CoolCast {
    public class Options : MonoBehaviour {
        public static int Lives { get; private set; }
        Options() {
            Lives = 3;
        }
        public static Options instance = null;

        void Awake() {
            CheckInstance();
        }

        private void CheckInstance() {
            if (instance == null)
                instance = this;
            else if (instance != this)
                Destroy(gameObject);
            DontDestroyOnLoad(gameObject);
        }

        public static void ChangeLives(int lives ) {
            Lives = lives;
        }

    }
}
