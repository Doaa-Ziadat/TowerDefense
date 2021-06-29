using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting1 : MonoBehaviour
{
    public GameObject obj;
    public Transform posofres;
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {

            Instantiate(obj, posofres.position, posofres.rotation);

        }
}
}
