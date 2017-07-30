using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartUIButton : MonoBehaviour {
    public bool selected;
    public string text;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (selected) {
            GetComponent<Text>().text=">"+text;
        }
        else
        {
            GetComponent<Text>().text = " " + text;
        }
	}
}
