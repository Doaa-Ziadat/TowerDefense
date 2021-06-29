using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rspawn_Enemy : MonoBehaviour
{
    public Transform[] ResPos;
    public GameObject Enemy;
    private int resnum;
    void Start()
    {
        StartCoroutine("wait");

    }

    void Update()
    {

    }
    IEnumerator wait()
    {
        yield return new WaitForSeconds(3f);

        resnum = Random.Range(0, ResPos.Length);
        if (resnum == 0)
        {
            Instantiate(Enemy, ResPos[0].position, ResPos[0].rotation);
        }
        if (resnum == 1)
        {
            Instantiate(Enemy, ResPos[1].position, ResPos[1].rotation);
        }
        if (resnum == 2)
        {
            Instantiate(Enemy, ResPos[2].position, ResPos[2].rotation);
        }
        if (resnum == 3)
        {
            Instantiate(Enemy, ResPos[3].position, ResPos[3].rotation);
        }


        yield return new WaitForSeconds(5f);
        Start();

    }



}
