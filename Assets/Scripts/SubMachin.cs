using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubMachin : MonoBehaviour
{
    public Transform TargetPos;
    public GameObject[] Target;
    public int num;
    public GameObject obj;
    public Transform posofres;
    public float ShootingTime;
    public bool canshot;
    void Start()
    {
        for (int i = 0; i < Target.Length; i++)
        {
            num = Random.Range(0, i);
        }
        canshot = false;
    }

    void Update()
    {
        Target = GameObject.FindGameObjectsWithTag("Enemy");


        transform.LookAt(TargetPos);
        TargetPos = Target[num].transform;


        if (canshot == true)
        {

            Shot();

        }
        




        }
 

    public void ONRES()
    {

        for (int i = 0; i < Target.Length; i++)
        {
            num = Random.Range(0, i);

        }

    }

    public void Shot()
    {

       
            Instantiate(obj, posofres.position, posofres.rotation);
              StartCoroutine("astna");


    }

    public IEnumerator astna()
    {
        yield return new WaitForSeconds(0.0002f);
        canshot = false;


    }
    public void OnTriggerEnter(Collider collider)
    {

        if (collider.tag == "Enemy")
        {
            canshot = true;
            Debug.Log("A7a");
        }

    }
    public void ONEND() {

        canshot = true;
    }
}
