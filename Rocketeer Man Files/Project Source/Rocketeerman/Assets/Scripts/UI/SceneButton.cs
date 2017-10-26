using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CoolCast;
using UnityEngine.SceneManagement;

namespace CoolCast {

    public class SceneButton : MonoBehaviour {

        private bool sceneSwitch = false;
        private bool sceneClose = false;
        private int scene = 0;
        private LoadSceneMode _SceneMode;
        

        // Using properties to encapsulate fields.
        public int Scene {
            get {
                return scene;
            }
            set {
                scene = value;
            }
        }
        public string SceneMode { // String Property because Enum is inaccessible within Unity UI Editor.
            get {
                return _SceneMode.ToString();
            }
            set { // Using string.Equals(stringA,stringB,StringComparison) comparison method to allow input of both uppercase and lowercase variant in editor.
                if (string.Equals(value,"Single",System.StringComparison.CurrentCultureIgnoreCase)) {
                    _SceneMode = LoadSceneMode.Single;
                }
                else if (string.Equals(value, "Additive", System.StringComparison.CurrentCultureIgnoreCase)) {
                    _SceneMode = LoadSceneMode.Additive;
                }
                else { // No valid string input found gives the Debug Log a prompt about the correct string values.
                    Debug.LogWarning("Invalid string ("+SceneMode+") specified at: " + gameObject.name + " it needs to be either 'Additive' or 'Single'.");
                }
            }
        }
        public bool SceneSwitch {
            get {
                return sceneSwitch;
            }
            set {
                sceneSwitch = value;
            }
        }

        public bool SceneClose {
            get {
                return sceneClose;
            }
            set {
                sceneClose = value;
            }
        }

        public void OnClick() {
            if (sceneSwitch) {
                GameManager.LoadScene(scene, _SceneMode);
            }
            if (sceneClose) {
                GameManager.CloseScene(scene);
            }
        }
    }
}
