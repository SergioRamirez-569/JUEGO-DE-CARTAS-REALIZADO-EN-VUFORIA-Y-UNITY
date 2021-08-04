using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackZombie : MonoBehaviour
{
    public Transform ninjaArmado;
    static Animator anim;
    public Transform Robot;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(ninjaArmado);
        //Debug.Log(Vector3.Distance(ninjaArmado.transform.position, this.transform.position));
        if (Vector3.Distance(ninjaArmado.transform.position, this.transform.position) < 3)
        {
            anim.Play("Z_Attack");
        }
        transform.LookAt(ninjaArmado);
        //Debug.Log(Vector3.Distance(ninjaArmado.transform.position, this.transform.position));
        if (Vector3.Distance(Robot.transform.position, this.transform.position) < 3)
        {
            anim.Play("Z_Attack");
        }
    }
}
