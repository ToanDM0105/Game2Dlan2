using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird2 : MonoBehaviour
{
    public bool b;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (b == true)
        {
            transform.Translate(0,Time.deltaTime * 3, 0);
            transform.localScale = new Vector3(5, 5, 5);
        }
        else
        {
            transform.Translate(0, -Time.deltaTime * 3,  0);
            transform.localScale = new Vector3(-5, 5, 5);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ghduoi")
        {
            b = true;
        }
        if (collision.gameObject.tag == "tren")
        {
            b = false;
        }

    }
}
