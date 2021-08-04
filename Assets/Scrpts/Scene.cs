using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour
{
    // Start is called before the first frame update
    public void cargarEscena(string nombreEscena)
    {
        SceneManager.LoadScene(nombreEscena);
    }
}
