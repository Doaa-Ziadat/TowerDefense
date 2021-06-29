using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerCont : MonoBehaviour
{
    public GameObject player;
    public float sensitivity;
    public float speed;
    private Animator anim;
    public GameObject obj;
    public Transform posofres;
    public Text tx;

    public int HP = 100;
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    void Update()
    {
        tx.text = "HP/ " + HP.ToString();
        if (Input.GetKey(KeyCode.W))
        {

            transform.Translate(Vector3.forward * speed * Time.deltaTime);
            anim.SetInteger("run", 1);


        }


        if (Input.GetKey(KeyCode.S))
        {

            transform.Translate(Vector3.back * speed * Time.deltaTime);
            anim.SetInteger("run", 1);
        }
        if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.S))
        {
            anim.SetInteger("run", 0);


        }
        if (Input.GetMouseButtonDown(0))
        {

            anim.SetInteger("shooting", 1);
            Instantiate(obj, posofres.position, posofres.rotation);

        }
        if (Input.GetMouseButtonUp(0))
        {

            anim.SetInteger("shooting", 0);
        }
    }
        void FixedUpdate()
    {
        float rotateHorizontal = Input.GetAxis("Mouse X");

        transform.RotateAround(player.transform.position, -Vector3.up, rotateHorizontal * sensitivity);
    }
}
