using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GerarPowerUpScript : MonoBehaviour
{

    public float tempoInicial, tempoFinal;
    public float esquerdaX, direitaX;
    public float topoY, embaixoY;
    public GameObject[] powerUpPrefab;
    public float tempoItem;

    void Start()
    {
        StartCoroutine(Gerar());
    }

    // Update is called once per frame
    void Update()
    {

    }

     IEnumerator Gerar()
     {

         int index = Random.Range(0, powerUpPrefab.Length);

         // aguarda um tempo para gerar PowerUP
         yield return new WaitForSeconds(tempoItem);

         // gera uma posição em X... usa a posição y e z do ponto que está na tela...
         Vector3 posicao = new Vector3(Random.Range(esquerdaX, direitaX),
                                         Random.Range(embaixoY, topoY), transform.position.z);
         // instancia o inimigo
         Instantiate(powerUpPrefab[index], posicao, transform.rotation);

         // executar uma Coroutine
         StartCoroutine(Gerar());

     }
}
