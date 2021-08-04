using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColliderEspadachina : MonoBehaviour
{
    public Slider HpAmazona;
    public Animator anim;
    public GameObject Amazona;
    
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("xdddd");
        if (other.gameObject.tag == "Amazonas")
        {
            Debug.Log("daño amazona");
            HpAmazona.value -= 10;
        }
        if (HpAmazona.value == 0)
        {
            Amazona.SetActive(false);
        }
    }
}
