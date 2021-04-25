using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class From_FirstScene_ToHome : MonoBehaviour
{
   public void To_HomeMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
