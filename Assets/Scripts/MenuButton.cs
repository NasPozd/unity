using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButton: MonoBehaviour
{
    public void StartScene(){
        Application.LoadLevel("New Scene");
    }

    public void Options(GameObject window){
        window.SetActive(true);
    }

    public void Quit(){
        Application.Quit();
    }
}
