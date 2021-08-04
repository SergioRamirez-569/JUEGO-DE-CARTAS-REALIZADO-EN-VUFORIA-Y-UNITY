using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerificandoCinco : MonoBehaviour
{
    public GameObject estrella5;
    // Start is called before the first frame update
    void Start()
    {
        estrella5.SetActive(false);
    }
    public void Activar()
    {
        estrella5.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
