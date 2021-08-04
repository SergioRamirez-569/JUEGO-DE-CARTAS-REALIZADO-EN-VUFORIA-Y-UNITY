using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Verificando : MonoBehaviour
{
    public GameObject estrella1;

    // Start is called before the first frame update
    void Start()
    {
        estrella1.SetActive(false);
    }
    public void Activar()
    {
        estrella1.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
