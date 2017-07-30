using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour {
    public int type;
	public GameController controller;
    public GameObject player;

    public AudioClip toPlay;

    public AudioSource source;
    // Use this for initialization

    void Start() {
        controller = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
        source = GameObject.FindGameObjectWithTag("GameController").GetComponent<AudioSource>();
    }
     void Update() {
    }
    public void OnDug (){
        Debug.Log("Tile dug of type" + type);
        source.PlayOneShot(toPlay, 1.0f);
        switch (type) {
            case 1:
                controller.power--;
                Destroy(gameObject);
                break;

            case 2:
                controller.power += 5;
                Destroy(gameObject);
                break;
            case 3:
                break;
   
        }

	}

}
