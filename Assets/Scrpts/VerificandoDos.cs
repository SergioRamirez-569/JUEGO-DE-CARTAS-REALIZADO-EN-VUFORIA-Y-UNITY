using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerificandoDos : MonoBehaviour
{
    public GameObject estrella2;
    // Start is called before the first frame update
    void Start()
    {
        estrella2.SetActive(false);
    }
    public void Activar()
    {
        estrella2.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
