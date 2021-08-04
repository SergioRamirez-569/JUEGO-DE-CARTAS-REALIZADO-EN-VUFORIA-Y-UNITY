using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColliderEnano : MonoBehaviour
{
    public Slider HpRobot;
    public Slider HpChica;
    public Animator anim;
    public GameObject Robot;
    public GameObject Chica;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Robot")
        {
            Debug.Log("daño chicamaga");
            HpRobot.value -= 20;
        }
        if (HpRobot.value == 0)
        {
            Robot.SetActive(false);
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
