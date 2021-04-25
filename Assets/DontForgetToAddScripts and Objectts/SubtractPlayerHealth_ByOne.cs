using UnityEngine;

public class SubtractPlayerHealth_ByOne : MonoBehaviour
{

    public void SubPlayerHealth_B1()
    {
        if(PlayerPrefs.GetInt("SavedScene") >= 8 && PlayerPrefs.GetInt("SavedScene") <= 16)
        {
            if (PlayerHealth_System.Player_MaxHealth > 2)
            {
                PlayerHealth_System.Player_MaxHealth -= 1;
            }
        }
    }


}
