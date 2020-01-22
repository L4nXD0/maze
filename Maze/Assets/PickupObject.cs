using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickupObject : MonoBehaviour
{
    public GameObject uiObject;
    public string newText;
    Text bla;
    private void Start()

    {
        uiObject.SetActive(false);
    }
    private void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.tag == "Player")
        {
            bla = uiObject.GetComponent<Text>();
            bla.text = newText;
            uiObject.SetActive(true);
            GetComponent<MeshRenderer>().enabled = false;
            GetComponent<Collider>().enabled = false;
            Destroy(gameObject); // replacable
            //StartCoroutine("WaitForSec");
        }
    }
    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(4);
        uiObject.SetActive(false);
        
        
        Destroy(gameObject);
    }
}
