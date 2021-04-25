using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class HowToPlay : MonoBehaviour
{
   public void Go_To_HowToPlay_Menu()
    {
        SceneManager.LoadScene("HowToPlay_Menu");
        Debug.Log("We are going to HowToPlay Menu1!!!");
    }
}
