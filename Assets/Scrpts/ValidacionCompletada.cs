using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ValidacionCompletada : MonoBehaviour
{
    public GameObject estrella1;
    public GameObject estrella2;
    public GameObject estrella3;
    public GameObject estrella4;
    public GameObject estrella5;
    public GameObject estrella6;
    public GameObject mensajeFinal;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(estrella1.activeInHierarchy && estrella2.activeInHierarchy && estrella3.activeInHierarchy && estrella4.activeInHierarchy && estrella5.activeInHierarchy && estrella6.activeInHierarchy)
        {
            mensajeFinal.SetActive(true);
        }
    }
}
