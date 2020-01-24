using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampOnOffEG : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            StartCoroutine("TurnLampsOff");

        }
    }
    IEnumerator TurnLampsOff()
    {
         foreach (Transform child in transform)
        {
            child.gameObject.SetActive(false);
        }
        return null;
    }
}
