
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {
    public int power = 20;
    public int score = 0;
    public float gameClock;
    public UIItem powertext;
    public UIItem scoretext;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (!PauseMenuController.paused)
        {
            gameClock += Time.deltaTime;
            if (gameClock > 1.0f)
            {
                score++;
                power--;
                gameClock = 0;
            }
            powertext.SetText(power);
            scoretext.SetText(score);
            if (power <= 0)
            {
                SceneManager.LoadScene(3);
            }
            if (score >= 50) {
                SceneManager.LoadScene(4);
            }
        }
	}
}
