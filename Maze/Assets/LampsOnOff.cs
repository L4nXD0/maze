using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampsOnOff : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            GetComponent<MeshRenderer>().enabled = false;
            Destroy(gameObject); // replacable

     
        }
    }
}
