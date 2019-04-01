using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUGuardaChuva : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DestroyPowerUp());
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.active) {
            StartCoroutine(DestroyPowerUp());
        }
    }
    private IEnumerator DestroyPowerUp(){
        
        yield return new WaitForSeconds(5);
        gameObject.SetActive(false);
    }
}
