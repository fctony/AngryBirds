using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevelAsync : MonoBehaviour {

    void Start() {
        Screen.SetResolution(960,600,false);
        Invoke("Load",2);
    }

    void Load() {
            SceneManager.LoadSceneAsync(1);
        }
    }

