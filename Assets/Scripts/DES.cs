using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DES : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine("astna");

    }
    public IEnumerator astna()
    {
        yield return new WaitForSeconds(1f);
        gameObject.active = false;
          }
}
