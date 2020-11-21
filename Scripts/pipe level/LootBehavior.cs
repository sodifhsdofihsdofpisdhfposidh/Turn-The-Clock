using UnityEngine;
using System.Collections;


public class LootBehavior : MonoBehaviour
{
    public GameObject Mechant;
    public GameObject Loot;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Mechant == null)
        {
            Loot.transform.position = new Vector2(-80.26f,-42.15f);
        }
    }
}
