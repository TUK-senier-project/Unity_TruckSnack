using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonEvent : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            OnClickButtonA();
    }
    public void OnClickButtonA()
    {
        Debug.Log("Clicked Button");
        Application.Quit();
    }

}
