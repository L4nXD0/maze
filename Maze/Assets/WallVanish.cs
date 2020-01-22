using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallVanish : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Destroy(GameObject.FindWithTag("Vanish"));
            Destroy(gameObject);
        }
    }
}
