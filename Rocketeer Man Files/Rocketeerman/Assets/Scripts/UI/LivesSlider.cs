using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CoolCast;
using UnityEngine.UI;

namespace CoolCast {
    public class LivesSlider : MonoBehaviour {
        public Text text;
        public Slider slider;
        // Use this for initialization
        void Start() {
            slider.value = Options.Lives;
        }

        // Update is called once per frame
        void Update() {
            if (text != null) {
                text.text = "Lives: " + Options.Lives;
            }
        }

        public void ChangeLives() {
            Options.ChangeLives((int)slider.value);
        }
    }
}
