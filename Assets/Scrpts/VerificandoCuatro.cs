using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerificandoCuatro : MonoBehaviour
{
    public GameObject estrella4;
    // Start is called before the first frame update
    void Start()
    {
        estrella4.SetActive(false);
    }
    public void Activar()
    {
        estrella4.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
