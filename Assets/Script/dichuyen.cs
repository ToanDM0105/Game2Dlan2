using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dichuyen : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator ani;
    public bool isRight = true;
    public GameObject SrcPause;
    public bool isPause = false;
    public AudioSource Jump;
    public AudioSource Pause;
    void Start()
    {
        ani = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        
        ani.SetBool("isRunning", false);
        if (Input.GetKey(KeyCode.RightArrow))
        {
            isRight = true;
            ani.SetBool("isRunning", true);
            ani.Play("Running");
            transform.Translate(Time.deltaTime * 3, 0, 0);
            transform.localScale = new Vector3(key_map.posx, key_map.posy, key_map.posz);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            isRight = false;
            ani.SetBool("isRunning", true);
            ani.Play("Running");
            transform.Translate(-Time.deltaTime * 3, 0, 0);
            transform.localScale = new Vector3(-key_map.posx, key_map.posy, key_map.posz);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            if (isRight == true)
            {
                Jump.Play();
                transform.Translate(0, Time.deltaTime * 10f, 0);
            }
            else
            {
                transform.Translate(0, Time.deltaTime * 10f, 0);
            }

        }
        if (Input.GetKey(KeyCode.P))
        {
            isPause = !isPause;
            if (isPause)
            {
                Pause.Play();
                c
                Time.timeScale = 0;
            }
            else
            {
                Pause.Play();
                SrcPause.SetActive(false);
                Time.timeScale = 1;
            }
        }
    }
   
}
