using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToFirstPage : MonoBehaviour
{
   public void HowToPlay_FirstPage()
    {
        SceneManager.LoadScene("HowToPlay_Menu");
    }
}
