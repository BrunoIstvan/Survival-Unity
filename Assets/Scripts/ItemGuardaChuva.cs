using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGuardaChuva : MonoBehaviour
{

    //Power UP Guarda Chuva
    public GameObject PUGuardaChuva;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Escudo")
        {
            print("bateu no escudo");
            //Instantiate(PUGuardaChuva, collision.gameObject.transform.position, transform.rotation);
            //Instantiate(PUGuardaChuva, transform);
            //collision.gameObject.transform.parent=transform;
            print(collision.gameObject.transform.GetChild(0));
            GameObject escudo = collision.gameObject.transform.GetChild(0).gameObject;

            escudo.SetActive(true);
            Destroy(gameObject, 0.0f);
        }

        if (collision.gameObject.tag == "Inimigo")
        {
            Physics2D.IgnoreCollision(collision.gameObject.GetComponent<Collider2D>(), this.GetComponent<Collider2D>(), true);
        }

        if (collision.gameObject.tag == "Finish")
        {
            Destroy(gameObject, 0.0f);
        }
    }
}
