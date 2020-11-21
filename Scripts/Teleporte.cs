using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporte : MonoBehaviour
{
    public GameObject camera;
    public GameObject background;
    public GameObject player;
    public GameObject horlogeTueuse;
    private Vector3[] tab;
    void Start()
    {
        tab = new Vector3[10];
        
    }

    // Update is called once per frame
    void Update()
    {
        remplir();
       

    }
    void OnTriggerEnter2D(Collider2D col)
    { 
        if (col.gameObject.CompareTag("Player"))
        {
            Stage.stage++;
           
            background.GetComponent<Stage>().changer();
            horlogeTueuse.GetComponent<Behavior>().changer();
            player.transform.position = tab[Stage.stage];
            StartCoroutine(Delai());
            camera.GetComponent<PlayerView>().changer();
            StartCoroutine(Delai());
            player.transform.localScale = new Vector3(0.3128078f, player.transform.localScale.y, 0);
            /*if (Stage.stage == 1) { camera.gameObject.GetComponent<AudioSource>().clip = camera.gameObject.GetComponent<MusicPlayer>().music2;
                 camera.gameObject.GetComponent<AudioSource>().Play();
                }
            else if (Stage.stage == 6) { camera.gameObject.GetComponent<AudioSource>().clip = camera.gameObject.GetComponent<MusicPlayer>().music1;
                    camera.gameObject.GetComponent<AudioSource>().Play();
                }
                */


        }
        if (Stage.stage == 1)
        {
            camera.gameObject.GetComponent<AudioSource>().clip = camera.gameObject.GetComponent<MusicPlayer>().music2;
            camera.gameObject.GetComponent<AudioSource>().Play();
        }
        else if (Stage.stage == 6)
        {
            camera.gameObject.GetComponent<AudioSource>().clip = camera.gameObject.GetComponent<MusicPlayer>().music1;
            camera.gameObject.GetComponent<AudioSource>().Play();
        }


    }
    void remplir()
    {
        tab[1] = new Vector3(79, -4.817848f, 0);
        tab[2] = new Vector3(190, -4.817848f, 0);
        tab[3] = new Vector3(300, -4.817848f, 0);
        tab[4] = new Vector3(430, -4.817848f, 0);
        tab[5] = new Vector3(580, -4.817848f, 0);
        tab[6] = new Vector3(720, -4.817848f, 0);
    }
    IEnumerator Delai()
    {
        yield return new WaitForSeconds(.0001f);
        

    }
}
