using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackEnano : MonoBehaviour
{
    public Transform Robot;
    static Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(Robot);
        //Debug.Log(Vector3.Distance(ninjaArmado.transform.position, this.transform.position));
        if (Vector3.Distance(Robot.transform.position, this.transform.position) < 3.5)
        {
            anim.Play("infantry_04_attack_A");
        }
    }
}
