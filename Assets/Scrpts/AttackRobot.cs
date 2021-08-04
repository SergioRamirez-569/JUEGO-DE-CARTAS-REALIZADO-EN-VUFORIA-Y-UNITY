using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackRobot : MonoBehaviour
{
    public Transform Enano;
    static Animator anim;
    public Transform Chica;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(Enano);
        //Debug.Log(Vector3.Distance(ninjaArmado.transform.position, this.transform.position));
        if (Vector3.Distance(Enano.transform.position, this.transform.position) < 3.5)
        {
            anim.Play("Crouch_Right_Punch");
        }
        transform.LookAt(Enano);
        //Debug.Log(Vector3.Distance(ninjaArmado.transform.position, this.transform.position));
        if (Vector3.Distance(Chica.transform.position, this.transform.position) < 3.5)
        {
            anim.Play("Crouch_Right_Punch");
        }
    }
}
