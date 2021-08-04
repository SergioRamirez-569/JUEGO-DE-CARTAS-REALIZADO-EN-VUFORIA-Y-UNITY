using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Comandos : MonoBehaviour
{
    // Start is called before the first frame update
    public void cargarEscena(string nombreEscena)
    {
        SceneManager.LoadScene(nombreEscena);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
