using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorujaScript : MonoBehaviour
{

    public AudioClip efeito;
    private AudioSource som;

    // Start is called before the first frame update
    void Start()
    {
        som = GetComponent<AudioSource>();
        som.clip = efeito;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other) 
    {
        som.Play();
    }

}
