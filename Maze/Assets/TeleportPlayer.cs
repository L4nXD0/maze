using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportPlayer : MonoBehaviour
{

    Vector3 playerStartPosition;
    // Start is called before the first frame update
    void Start()
    {
<<<<<<< Updated upstream
        playerStartPosition = transform.position;
=======
         playerStartPosition = transform.position;
>>>>>>> Stashed changes
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Teleporter")
        {
            transform.position = playerStartPosition;
        }
    }
}
