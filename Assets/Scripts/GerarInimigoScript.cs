using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GerarInimigoScript : MonoBehaviour
{

    public float tempoInicial, tempoFinal;
    public float esquerdaX, direitaX;
    public float topoY, embaixoY;
    public GameObject[] inimigosPrefab;

    // Start is called before the first frame update
    void Start()
    {
        // executar uma Coroutine
        StartCoroutine(Gerar());
    }

    // Update is called once per frame
    void Update()
    {
           
    }

    IEnumerator Gerar() {

        int index = Random.Range(0, inimigosPrefab.Length);

        // aguarda um tempo gerado randomicamente
        yield return new WaitForSeconds(Random.Range(tempoInicial, tempoFinal));
        // gera uma posição em X... usa a posição y e z do ponto que está na tela...
        Vector3 posicao = new Vector3(Random.Range(esquerdaX, direitaX), 
                                        Random.Range(embaixoY, topoY), transform.position.z);
        // instancia o inimigo
        Instantiate(inimigosPrefab[index], posicao, transform.rotation);

        // executar uma Coroutine
        StartCoroutine(Gerar());

    }
}
