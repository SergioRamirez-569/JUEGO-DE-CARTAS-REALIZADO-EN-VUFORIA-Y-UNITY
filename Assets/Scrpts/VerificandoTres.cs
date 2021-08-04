using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerificandoTres : MonoBehaviour
{
    public GameObject estrella3;
    // Start is called before the first frame update
    void Start()
    {
        estrella3.SetActive(false);
    }
    public void Activar()
    {
        estrella3.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
