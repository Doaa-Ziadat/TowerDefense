using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diss : MonoBehaviour
{
    void Start()
    {
        
    }


    void Update()
    {

        StartCoroutine("wait");
        
    }


    IEnumerator wait() {

        yield return new WaitForSeconds (30f);
        gameObject.active = false;

    }
}
