using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackMaga : MonoBehaviour
{
    public Transform chicaMaga;
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
        transform.LookAt(chicaMaga);
        if (Vector3.Distance(chicaMaga.transform.position, this.transform.position)<3)
        {
            anim.Play("WAIT04");
        }
        transform.LookAt(chicaMaga);
        if (Vector3.Distance(Robot.transform.position, this.transform.position) < 3)
        {
            anim.Play("WAIT04");
        }
    }
}
