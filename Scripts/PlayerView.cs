using UnityEngine;
using System.Collections;

public class PlayerView : MonoBehaviour
{
    public GameObject porte;
    public GameObject player;
    public GameObject playerSpawn;
    public GameObject playerEnd;
    public Camera mainCamera;
    public GameObject horloge;
    private  Vector3[] tab;
    private bool a = true;
    
    //Public variable to store a reference to the player game object


    public static Vector3 offset;            //Private variable to store the offset distance between the player and camera

    // Use this for initialization
    void Start()
    {
        //Calculate and store the offset value by getting the distance between the player's position and camera's position.
        offset = transform.position - player.transform.position;
        mainCamera.orthographicSize = 6;
        tab = new Vector3[10];
        this.remplir();

    }

    // LateUpdate is called after Update each frame
    void LateUpdate()
    {
        if (playerSpawn.activeSelf)
        {
            
            transform.position = new Vector3(765.5983f, -0.5500002f, -10);
            
       
            
        }
        else if (!playerSpawn.activeSelf && a)
        {
            
            Stage.stage = 0;
            mainCamera.orthographicSize = 15;
            playerEnd.SetActive(true);
            a = false;

        }
        else if (player != null && (Stage.stage==0 || Stage.stage ==6) )
        {
            
            transform.position = player.transform.position + offset;
           
        }
        else if (player != null && Stage.stage >0)
        {
            
            transform.position = horloge.transform.position + offset;
        }
       



    }
    public void changer()
    {
        mainCamera.orthographicSize = 6;
        transform.position = tab[Stage.stage];
        offset = transform.position - horloge.transform.position;
        if (Stage.stage == 6)
        {
            offset = transform.position - player.transform.position;
        }

    }
    public void remplir()
    {
        tab[0] = new Vector3(0, 0, 0);
        tab[1]= new Vector3(83f, -0.55f, -10);
        tab[2] = new Vector3(193, -0.55f, -10);
        tab[3] = new Vector3(303, -0.55f, -10);
        tab[4] = new Vector3(433, -0.55f, -10);
        tab[5] = new Vector3(583, -0.55f, -10);
        tab[6] = new Vector3(723, -0.55f, -10);
    }
}