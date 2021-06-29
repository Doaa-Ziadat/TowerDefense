using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCont : MonoBehaviour
{
    public GameObject player;
    public float sensitivity;
    public float speed;
    private Animator anim;
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    void Update()
    {

        if (Input.GetKey(KeyCode.W)) {

            transform.Translate(Vector3.forward * speed * Time.deltaTime);
            anim.SetInteger("run", 1);


        }
        

        if (Input.GetKey(KeyCode.S))
        {

            transform.Translate(Vector3.back * speed * Time.deltaTime);
            anim.SetInteger("run", 1);
        }
        if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.S)) {
            anim.SetInteger("run", 0);


        }
    }
    void FixedUpdate()
    {
        float rotateHorizontal = Input.GetAxis("Mouse X");

        transform.RotateAround(player.transform.position, -Vector3.up, rotateHorizontal * sensitivity);
    }
}
