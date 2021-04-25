using UnityEngine;
public class CriticalHitUpgrade : MonoBehaviour
{
    public static int CriticalHitUpgrade_Price = 1000;

    private void CriticalHitUpgrade_Condition()
    {
        if (PlayerPrefs.GetInt("SavedScene") > 7)
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
        CriticalHitUpgrade_Condition();
    }

    private void Update()
    {
        if(PlayerPrefs.GetInt("SavedScene") > 7)
        {
            gameObject.SetActive(true);
        }
        else
        {
            gameObject.SetActive(false);
        }
    }

    public void CriticalUpgrade()
    {
        if(BronzeItem_System.Total_Clickpoints >= CriticalHitUpgrade_Price)
        {
            BronzeItem_System.Total_Clickpoints -= CriticalHitUpgrade_Price;
            CriticalFunction.CriticalDamage += 2;
        }
        else
        {
            Debug.Log("You don't have enough clickpoints");
        }
    }
}
