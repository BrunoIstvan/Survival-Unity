using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscudoScript : MonoBehaviour
{
    public float velocidade;
    public float alturaY;
    public float limiteY;
    private bool encostouNaTravaPassagem = false;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButton("Fire1")) 
        {

            // recebe o touche na tela e converte em coordenada do mundo
            Vector2 posicaoMouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            if(encostouNaTravaPassagem) 
            {

                if(posicaoMouse.y > limiteY) 
                {
                    // Reatribui a posição do mouse adicionando altura em Y
                    posicaoMouse = new Vector2(posicaoMouse.x, 
                                        posicaoMouse.y + alturaY);
                } 
                else 
                {
                    // Reatribui a posição do mouse adicionando altura em Y
                    posicaoMouse = new Vector2(posicaoMouse.x, limiteY);
                }
                
                // Move o objeto para coordenada indicada
                transform.position = Vector2.Lerp(transform.position, posicaoMouse, 
                                            velocidade * Time.deltaTime);

            } 
            else 
            { 
                // Reatribui a posição do mouse adicionando altura em Y
                posicaoMouse = new Vector2(posicaoMouse.x, 
                                        posicaoMouse.y + alturaY);

                // Move o objeto para coordenada indicada
                transform.position = Vector2.Lerp(transform.position, posicaoMouse, 
                                            velocidade * Time.deltaTime);

            }

        }
    }

    void OnTriggerEnter2D(Collider2D c)
    {
        Collider2D obj = c.GetComponent<Collider2D>();

        if(obj.transform.name == "LimiteEscudo") 
        {
           encostouNaTravaPassagem = true;
        }
        
    }

    void OnTriggerExit2D(Collider2D c)
    {
        encostouNaTravaPassagem = false;
    }

}
