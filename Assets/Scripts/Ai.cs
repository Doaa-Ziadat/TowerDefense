using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ai : MonoBehaviour
{
    private GameObject[] Target;
    private Transform TargetPos;
    public float speed;
    public bool attack;
    private Animator anim;
    public int HP = 100;
    private PlayerCont Pcode;
    void Start()
    {
        Target = GameObject.FindGameObjectsWithTag("Player");
        anim = gameObject.GetComponent<Animator>();
        Pcode = Target[0].GetComponent<PlayerCont>();
        attack = false;
    }

    void Update()
    {
        if (HP > 0)
        {
            TargetPos = Target[0].transform;
            transform.LookAt(TargetPos);
        }
        if (attack == false)
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
            anim.SetBool("attack", false);
        }



        if (HP < 0 || HP == 0) {

            anim.SetBool("dead", true);
            speed = 0;
            Destroy(gameObject, 6f);
            
        }

    }
    void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Player")
        {

            attack = true;
            anim.SetBool("attack", true);


        }
        if (collider.tag == "Bullet" && HP>0)
        {
            HP = HP - 15;
        }
    }
    void OnTriggerExit(Collider collider)
    {
        if (collider.tag == "Player")
        {
            attack = false;
            anim.SetBool("attack", false);

        }
    }

    public void Damge() {

        Pcode.HP = Pcode.HP - 10;
    }
    }