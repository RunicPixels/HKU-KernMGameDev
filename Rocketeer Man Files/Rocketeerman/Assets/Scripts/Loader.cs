using UnityEngine;
using System.Collections;
using CoolCast;

namespace CoolCast {
    public class Loader : MonoBehaviour {
        void Awake() {
            DontDestroyOnLoad(gameObject);
            GameManager.LoadScene(1);
        }
    }
}