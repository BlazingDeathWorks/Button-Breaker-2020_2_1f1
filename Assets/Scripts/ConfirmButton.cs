using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ConfirmButton : MonoBehaviour
{
    public static bool ConfirmEntryDestroy = false;

    public void ConfirmEntry()
    {
        if(ConfirmEntryDestroy == false)
        {
            ConfirmEntryDestroy = true;
            SceneManager.LoadScene("CombinationI Dungeon");
        }
        else if(ConfirmEntryDestroy == true)
        {
            Debug.Log("You can't do this bonus course again");
        }
    }
}
