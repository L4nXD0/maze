using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class TeleportPlayer : MonoBehaviour
{

    private Vector3 playerStartPosition;
    // Start is called before the first frame update
    void Start()
    {
        /*FirstPersonController.enabled = false;
         characterController.transform.position = pos;
         characterController.enabled = true;*/
         //GetComponent<FirstPersonController>().enabled = false;
         playerStartPosition = transform.position;
         //GetComponent<FirstPersonController>().enabled = true;
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Teleporter")
        {
            GetComponent<CharacterController>().enabled = false;
            transform.position = playerStartPosition;
            GetComponent<CharacterController>().enabled = true;
        }
    }
}
