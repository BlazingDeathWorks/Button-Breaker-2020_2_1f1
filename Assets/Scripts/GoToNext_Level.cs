using UnityEngine;
using UnityEngine.SceneManagement;
public class GoToNext_Level : MonoBehaviour
{
    public void GotoNext_level()
    {
        if(PlayerPrefs.GetInt("SavedScene") <= 49)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else if(PlayerPrefs.GetInt("SavedScene") == 50)
        {
            ButtonBreaker_Button.Button_MaxDurability = 75;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
