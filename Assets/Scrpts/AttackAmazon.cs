using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackAmazon : MonoBehaviour
{
    public Transform Espadachina;
    static Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(Espadachina);
        //Debug.Log(Vector3.Distance(ninjaArmado.transform.position, this.transform.position));
        if (Vector3.Distance(Espadachina.transform.position, this.transform.position) < 5)
        {
            anim.Play("Attack");
        }
    }
}
