using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InimigoScript : MonoBehaviour
{

    public static bool parado = false; 

    // Start is called before the first frame update
    void Start()
    {
        //Destroy(gameObject, 10.0f);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1") && parado) {

            parado = false;
            Time.timeScale = 1.0f;
            SceneManager.LoadScene("GameScene");

        }
    }

    void FixedUpdate() {

        transform.Rotate(new Vector3(0, 0, 3));

    }

    private void OnCollisionEnter2D(Collision2D collision) 
    {

        if(collision.gameObject.tag == "Finish") 
        {
            PontuacaoScript.inimigosVencidos++;
            Destroy(gameObject, 0.0f);
        }
        else if(collision.gameObject.tag == "Player") 
        {
            parado = true;
            Time.timeScale = 0.0f;
        }

    }

}
