using UnityEngine;
using UnityEngine.SceneManagement;

public class To_HomeUnsaved : MonoBehaviour
{
    private void Awake()
    {
        gameObject.SetActive(false);
        Invoke("SetGameobjectTrue", 0.5f);
    }

    void SetGameobjectTrue()
    {
        gameObject.SetActive(true);
    }
    public void LoadTheLastChapter()
    {
        Countdown_System.Countdown_Current_Time = 60;
        ButtonBreaker_Button.Button_MaxDurability = 75;
        LevelSystem_P1.Level = 1;
        LevelSystem_P1.Total_XP = 0;
        LevelSystem_P1.XP_Needed = 100;
        PlayerHealth_System.Player_MaxHealth = 10;
        DefaultItem_System.Default_Equipped = true;
        BronzeItem_System.Total_Clickpoints = 0;
        BronzeItem_System.Bronze_Acquired = false;
        BronzeItem_System.Bronze_Equipped = false;
        SilverItem_System.Silver_Acquired = false;
        SilverItem_System.Silver_Equipped = false;
        GoldItem_System.Gold_Acquired = false;
        GoldItem_System.Gold_Equipped = false;
        PlatinumItem_System.Platinum_Acquired = false;
        PlatinumItem_System.Platinum_Equipped = false;
        DiamondItem_System.Diamond_Acquired = false;
        DiamondItem_System.Diamond_Equipped = false;
        CriticalFunction.CriticalDamage = 50;
        IncomeSystem.Income_Rate = 30;
        IncomeSystem.Income_Earnings = 5;
        Edox_AutoSystem.AutoDamage = 5;
        Edox_AutoSystem.AutoDamage_Rate = 5;
        Edox_AutoSystem.AutoDamage_Multiplier = 1;
        AutoCritUpgrade.AutoCritEquipped = 0;
        AutoCritUpgrade.AutoCritUpgradeBought = 0;
        SceneManager.LoadScene("ButtonBreaker_FirstScene");
    }

}
