using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightFlickering : MonoBehaviour
{
    public bool on = false;
    public int flickerSpeed = 2;
    private int randomizer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (on) { 
        if (randomizer == 0) {
            GetComponent<Light>().enabled = false;
        }
        else {
            GetComponent<Light>().enabled = true;
        }
        randomizer = Random.Range(0, flickerSpeed);
        //yield WaitForSeconds(flickerSpeed);
        StartCoroutine("WaitForSec");
        }
    }
    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(randomizer);
    }
}
