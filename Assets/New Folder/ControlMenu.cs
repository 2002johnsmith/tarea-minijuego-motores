using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlMenu : MonoBehaviour
{
    private SceneManager Escenas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void EscenaJuego()
    {
        SceneManager.LoadScene("SceneGame");
    }
    public void opciones(string escenas)
    {
        SceneManager.LoadScene(escenas);
    }
    public void Salida()
    {
        Application.Quit();
    }
}
