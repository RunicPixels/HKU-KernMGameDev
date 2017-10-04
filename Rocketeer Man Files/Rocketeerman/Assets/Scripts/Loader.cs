using UnityEngine;
using System.Collections;
using CoolCast;
using UnityEngine.SceneManagement;

namespace CoolCast {
    public class Loader : MonoBehaviour {
        void Awake() {
            DontDestroyOnLoad(gameObject);
            GameManager.LoadScene(1);
        }
    }
}