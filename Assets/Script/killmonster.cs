using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killmonster : MonoBehaviour
{
    public AudioSource Main;
    public AudioSource Coin;
    public AudioSource Dead;
    public GameObject SrcPause;
    // Start is called before the first frame update
    void Start()
    {
        Main.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        string name_coin = collision.attachedRigidbody.gameObject.name;
        if (collision.gameObject.tag == "xu")
        {
            Coin.Play();
            Destroy(GameObject.Find(name_coin));
        }
        if (collision.gameObject.tag == "roi")
        {
            Dead.Play();
            Main.Stop();
            Destroy(GameObject.Find("Lep_11"));
            Time.timeScale = 0;
            SrcPause.SetActive(true);
        }

    }
   
}
