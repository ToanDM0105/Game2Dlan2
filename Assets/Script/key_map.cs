using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class key_map : MonoBehaviour
{
    bool keymap = false;
  public static  bool nam = false;
    public GameObject key;
    public GameObject level;
    public GameObject main;
    public static float posx;
    public static float posy;
    public static float posz;
    // Start is called before the first frame update
    void Start()
    {
        posx = 3f;
        posy = 3f;
        posz = 3f;
    }

    // Update is called once per frame
    void Update()
    {
        if (nam) {
            posx = 5f;
            posy = 5f;
            posz = 5f;
        }
  
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "key_map") {
            keymap = true;
            Destroy(key, 0);
        }
        if (keymap) {
            if (collision.gameObject.tag == "loadmap")
            {
                SceneManager.LoadScene("Login");
            }
        }
        if (collision.gameObject.tag == "level")
        {
            nam = true;
            Destroy(level, 0);
        }


    }
}
