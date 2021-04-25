using UnityEngine;

public class MaxHealthPurchase : MonoBehaviour
{
    public PlayerHealth_System PlayerHealth_System;
    private int HealthUpgrade_Price = 3000;

    private void MaxHealthUpgrade_Condition()
    {
        if (PlayerPrefs.GetInt("SavedScene") > 17)
        {
            gameObject.SetActive(true);
        }
        else
        {
            gameObject.SetActive(false);
        }
    }

    private void Start()
    {
        MaxHealthUpgrade_Condition();
    }

    private void Update()
    {
        HealthUpgrade_Price = 3000;
        if (PlayerPrefs.GetInt("SavedScene") > 17)
        {
            gameObject.SetActive(true);
        }
        else
        {
            gameObject.SetActive(false);
        }
    }

    public void HealthUpgrade()
    {
        if(BronzeItem_System.Total_Clickpoints >= HealthUpgrade_Price && PlayerPrefs.GetInt("SavedScene") >= 17)
        {
            BronzeItem_System.Total_Clickpoints -= HealthUpgrade_Price;
            PlayerHealth_System.Player_MaxHealth += 1;
            PlayerHealth_System.Player_CurrentHealth = PlayerHealth_System.Player_MaxHealth;
            PlayerHealth_System.playerhealthtext.text = ("Player HP: ") + PlayerHealth_System.Player_CurrentHealth;
        }
        else
        {
            Debug.Log("You don't have enough money or you are too low leveled");
        }
    }

}
