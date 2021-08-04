using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class colliderChica : MonoBehaviour
{
    public Slider HpRobot;
    public Slider HpNinja;
    public Animator anim;
    public GameObject Ninja;
    public GameObject Robot;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Ninja")
        {
            HpNinja.value -= 50;
        }
        if (HpNinja.value == 0)
        {
            Ninja.SetActive(false);
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
