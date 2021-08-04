using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class colliderNinja : MonoBehaviour
{
    public Slider HpChicaMaga;
    public Slider HpRobot;
    public Animator anim;
    public GameObject Chica;
    public GameObject Robot;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "chicaMaga")
        {
            Debug.Log("daño chicamaga");
            HpChicaMaga.value -= 10;
        }
        if (HpChicaMaga.value == 0)
        {
            Chica.SetActive(false);
            if (other.gameObject.tag == "Robot")
            {
                Debug.Log("daño robot");
                HpRobot.value -= 10;
            }
            if (HpRobot.value == 0)
            {
                Robot.SetActive(false);
            }
        }
    }
}
