﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayNextLevel : MonoBehaviour
{

    public void PlayLevel()
    {
        ReturnRestartedFrom_Start();
        SceneManager.LoadScene(PlayerPrefs.GetInt("SavedScene"));
    }

    void ReturnRestartedFrom_Start()
    {
        LevelSystem_P1.Level = PlayerPrefs.GetInt("SavedLevel");
        BronzeItem_System.Total_Clickpoints = PlayerPrefs.GetInt("SavedClickPoints");
        PlayerHealth_System.Player_MaxHealth = PlayerPrefs.GetInt("SavedPlayerHealth");
        CriticalFunction.CriticalDamage = PlayerPrefs.GetInt("SavedCriticalDamage");
        LevelSystem_P1.Total_XP = PlayerPrefs.GetInt("SavedTotalXP");
        LevelSystem_P1.XP_Needed = PlayerPrefs.GetInt("SavedXPNeeded");
        IncomeSystem.Income_Rate = PlayerPrefs.GetFloat("SavedIncomeRate");
        IncomeSystem.Income_Earnings = PlayerPrefs.GetInt("SavedIncomeEarnings");
        Edox_AutoSystem.AutoDamage = PlayerPrefs.GetInt("SavedAutoDamage");
        Edox_AutoSystem.AutoDamage_Rate = PlayerPrefs.GetFloat("SavedAutoDamageRate");
        Edox_AutoSystem.AutoDamage_Multiplier = PlayerPrefs.GetInt("SavedAutoDamageMultiplier");
        AutoCritUpgrade.AutoCritEquipped = PlayerPrefs.GetInt("SavedAutoCritEquipped");
        AutoCritUpgrade.AutoCritUpgradeBought = PlayerPrefs.GetInt("SavedAutoCritBought");
    }

}
