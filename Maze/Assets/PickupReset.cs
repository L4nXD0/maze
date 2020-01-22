using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickupReset : MonoBehaviour
{
    public GameObject uiObject;
    public GameObject player;
    public string newText;
    Text bla;
   Vector3 playerStartPosition;
    private void Start()

    {
        playerStartPosition = player.transform.position;
        uiObject.SetActive(false);
    }
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            bla = uiObject.GetComponent<Text>();
            bla.text = newText;
            uiObject.SetActive(true);
            //GetComponent<MeshRenderer>().enabled = false;
            // GetComponent<Collider>().enabled = false;
            player.transform.position= playerStartPosition;
            //player.transform.position= new Vector3(-14.95f, 104.1f, -20.62f);
            StartCoroutine("WaitForSec");
            
        }
    }
    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(4);
        uiObject.SetActive(false);


        //Destroy(gameObject);
    }
}
