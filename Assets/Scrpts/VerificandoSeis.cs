using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerificandoSeis : MonoBehaviour
{
    public GameObject estrella6;
    void Start()
    {
        estrella6.SetActive(false);
    }
    public void Activar()
    {
        estrella6.SetActive(true);
    }
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        
    }
}
