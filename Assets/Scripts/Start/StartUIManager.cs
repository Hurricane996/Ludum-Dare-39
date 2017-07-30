using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartUIManager : MonoBehaviour {
    public StartUIButton start;
    public StartUIButton instructions;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.DownArrow)
            || Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.S)) {
            start.selected = !start.selected;
            instructions.selected = !instructions.selected;
        }
        if (Input.GetKeyDown(KeyCode.Return)) {
            if (start.selected) {
                SceneManager.LoadScene(2);
            }
            else {
                SceneManager.LoadScene(1);
            }
        }
        if (Input.GetKeyDown(KeyCode.Escape)) {
            Application.Quit();
        }
	}
}
