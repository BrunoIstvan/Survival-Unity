using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomFundoScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(InimigoScript.parado) 
        {
            GetComponent<AudioSource>().enabled = false;
        } 
        else 
        {
            GetComponent<AudioSource>().enabled = true;
        }
    }
}
