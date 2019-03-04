using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class IniciarScript : MonoBehaviour
{
    private Button btnIniciar;

    // Start is called before the first frame update
    void Start()
    {
        btnIniciar = GetComponent<Button>();
        btnIniciar.onClick.AddListener(Entrar);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Entrar()
    {
        SceneManager.LoadScene("GameScene");
    }
}