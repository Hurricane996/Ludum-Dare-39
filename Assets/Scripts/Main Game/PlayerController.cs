using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Grid grid;

    public float timerW;
    public float timerS;
    public float timerA;
    public float timerD;
    public float speed;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timerW += Time.deltaTime;
        timerS += Time.deltaTime;
        timerA += Time.deltaTime;
        timerD += Time.deltaTime;
        if (!PauseMenuController.paused)
        {
            if (Input.GetKey(KeyCode.W) && timerW > speed && transform.position.y < 98)
            {
                timerW = 0;
                transform.position = new Vector3(transform.position.x, transform.position.y + 1);
                grid.tiles[(int)transform.position.x, (int)transform.position.y].GetComponent<Tile>().OnDug();
                if (grid.tiles[(int)transform.position.x, (int)transform.position.y] != null)
                {
                    GetComponent<Animator>().SetTrigger("Hit");
                    grid.tiles[(int)transform.position.x, (int)transform.position.y].GetComponent<Tile>().OnDug();
                }
            }
            if (Input.GetKey(KeyCode.S) && timerS > speed && transform.position.y > 1)
            {
                timerS = 0;
                transform.position = new Vector3(transform.position.x, transform.position.y - 1);
                grid.tiles[(int)transform.position.x, (int)transform.position.y].GetComponent<Tile>().OnDug();
                if (grid.tiles[(int)transform.position.x, (int)transform.position.y] != null)
                {
                    GetComponent<Animator>().SetTrigger("Hit");
                    grid.tiles[(int)transform.position.x, (int)transform.position.y].GetComponent<Tile>().OnDug();
                }
            }
            if (Input.GetKey(KeyCode.A) && timerA > speed && transform.position.x > 1)
            {
                timerA = 0;
                transform.position = new Vector3(transform.position.x - 1, transform.position.y);
                GetComponent<SpriteRenderer>().flipX = true;
                if (grid.tiles[(int)transform.position.x, (int)transform.position.y] != null)
                {
                    GetComponent<Animator>().SetTrigger("Hit");
                    grid.tiles[(int)transform.position.x, (int)transform.position.y].GetComponent<Tile>().OnDug();
                }


            }
            if (Input.GetKey(KeyCode.D) && timerD > speed && transform.position.x < 98)
            {
                timerD = 0;
                transform.position = new Vector3(transform.position.x + 1, transform.position.y);
                GetComponent<SpriteRenderer>().flipX = false;
                if (grid.tiles[(int)transform.position.x, (int)transform.position.y] != null)
                {
                    GetComponent<Animator>().SetTrigger("Hit");
                    grid.tiles[(int)transform.position.x, (int)transform.position.y].GetComponent<Tile>().OnDug();
                }

            }

        }
    }
}
