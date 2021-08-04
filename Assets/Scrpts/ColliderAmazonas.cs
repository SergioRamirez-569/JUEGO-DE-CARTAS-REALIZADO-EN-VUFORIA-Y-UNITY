using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColliderAmazonas : MonoBehaviour
{
    public Slider HpCaballero;
    public Animator anim;
    public GameObject Caballero;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Espadachina")
        {
            Debug.Log(":C");
            HpCaballero.value -= 50;
        }
        if (HpCaballero.value == 0)
        {
            Caballero.SetActive(false);
        }
    }
}
