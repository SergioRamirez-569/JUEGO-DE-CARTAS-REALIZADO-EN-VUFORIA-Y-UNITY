using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColliderRobot : MonoBehaviour
{
    public Slider HpEnano;
    public Slider HpChica;
    public Animator anim;
    public GameObject Enano;
    public GameObject Chica;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enano")
        {
            Debug.Log("daño enano");
            HpEnano.value -= 19;
        }
        if (HpEnano.value == 0)
        {
            Enano.SetActive(false);
            if (other.gameObject.tag == "chicaMaga")
            {
                Debug.Log("daño chicamaga");
                HpChica.value -= 10;
            }
            if (HpChica.value == 0)
            {
                Chica.SetActive(false);
            }
        }

    }
}
