using UnityEngine;
using UnityEngine.SceneManagement;
public class SaveData_Start : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake ()
    {
        PlayerPrefs.SetInt("SavedLevel", LevelSystem_P1.Level);
        PlayerPrefs.SetInt("SavedClickPoints", BronzeItem_System.Total_Clickpoints);
        PlayerPrefs.SetInt("SavedScene", SceneManager.GetActiveScene().buildIndex);
        PlayerPrefs.SetInt("SavedPlayerHealth", PlayerHealth_System.Player_MaxHealth);
        PlayerPrefs.SetInt("SavedCriticalDamage", CriticalFunction.CriticalDamage);
        PlayerPrefs.SetInt("SavedTotalXP", LevelSystem_P1.Total_XP);
        PlayerPrefs.SetInt("SavedXPNeeded", LevelSystem_P1.XP_Needed);
        PlayerPrefs.SetFloat("SavedIncomeRate", IncomeSystem.Income_Rate);
        PlayerPrefs.SetInt("SavedIncomeEarnings", IncomeSystem.Income_Earnings);
        PlayerPrefs.SetInt("SavedAutoDamage", Edox_AutoSystem.AutoDamage);
        PlayerPrefs.SetFloat("SavedAutoDamageRate", Edox_AutoSystem.AutoDamage_Rate);
        PlayerPrefs.SetInt("SavedAutoDamageMultiplier", Edox_AutoSystem.AutoDamage_Multiplier);
        PlayerPrefs.SetInt("SavedAutoCritEquipped", AutoCritUpgrade.AutoCritEquipped);
        PlayerPrefs.SetInt("SavedAutoCritBought", AutoCritUpgrade.AutoCritUpgradeBought);
    }
}
