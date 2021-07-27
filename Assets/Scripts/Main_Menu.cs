using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main_Menu : MonoBehaviour
{
    public string roomname;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void ON_CLICKGOTO() {

        Application.LoadLevel(roomname);
    }
    public void ON_CLICKEXit()
    {

        Application.Quit();
    }
}
