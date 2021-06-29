using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float speed;
    void Start()
    {

    }


    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        Destroy(gameObject, 3);
    }
    void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Enemy")
        {

            Debug.Log("am hit an enemy");
            Destroy(gameObject);

        }

    }
}
