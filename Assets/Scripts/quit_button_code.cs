using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quit_button_code : MonoBehaviour
{
  public void Quit_ButtonBreaker()
    {
        Application.Quit();
        Debug.Log("We have Quit");
    }
}
