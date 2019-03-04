using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PontuacaoScript : MonoBehaviour
{
    public static int inimigosVencidos;
    public static int tempo;
    public Text tempoPlacar;
    public Text inimigosPlacar;

    private IEnumerator ContarPlacarTempo()
    {
        yield return new WaitForSeconds(1);
        if (!InimigoScript.parado)
        {
           tempo++;
           tempoPlacar.text = tempo.ToString();
           StartCoroutine(ContarPlacarTempo());
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        inimigosVencidos = 0;
        tempo = 0;
        StartCoroutine(ContarPlacarTempo());
    }

    // Update is called once per frame
    void Update()
    {
        inimigosPlacar.text = inimigosVencidos.ToString();
    }

}
