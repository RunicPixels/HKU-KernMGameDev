using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using CoolCast;

namespace CoolCast {
    public class GameManager : MonoBehaviour {
        public static GameManager instance = null;

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

        public static void LoadScene(int scene, LoadSceneMode sceneMode = LoadSceneMode.Single) {
            // Safety Check to prevent the same scene being loaded more than once.
            bool createScene = true;
            for (int i = 0; i < SceneManager.sceneCount; i++) {
                if (SceneManager.GetSceneAt(i).buildIndex == scene) {
                    CloseScene(scene);
                    createScene = false;
                }
            }
            if (createScene) {
                switch (sceneMode) { // Switch Statement
                    case LoadSceneMode.Additive:

                        SceneManager.LoadSceneAsync(scene, LoadSceneMode.Additive);
                        break;
                    case LoadSceneMode.Single:
                        SceneManager.LoadSceneAsync(scene, LoadSceneMode.Single);
                        break;
                    default:
                        SceneManager.LoadSceneAsync(scene, LoadSceneMode.Single);
                        break;
                }
            }
        }
        public static void CloseScene(int scene) {
            SceneManager.UnloadSceneAsync(scene);
        }

    }
}
