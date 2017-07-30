using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuController : MonoBehaviour {
    public static bool paused;
    public GameObject pauseDisplay;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            paused = !paused;
            pauseDisplay.SetActive(paused);
        }
        if (Input.GetKeyDown(KeyCode.Return) && paused) {
            paused = false;
            SceneManager.LoadScene(0);
        }
	}
}
