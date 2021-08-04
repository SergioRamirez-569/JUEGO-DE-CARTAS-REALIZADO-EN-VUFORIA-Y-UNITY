using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackEspadachina : MonoBehaviour
{
    public Transform Amazonas;
    static Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(Amazonas);
        //Debug.Log(Vector3.Distance(ninjaArmado.transform.position, this.transform.position));
        if (Vector3.Distance(Amazonas.transform.position, this.transform.position) < 5)
        {
            anim.Play("arthur_attack_01");
        }
    }
}
