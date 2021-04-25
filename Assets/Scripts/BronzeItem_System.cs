using UnityEngine;
using UnityEngine.UI;

public class BronzeItem_System : MonoBehaviour
{
    [SerializeField]
    private Text bronze_itemcost;
    [HideInInspector]
    public static int BronzeItem_Cost = 750;
    public static int Total_Clickpoints = 0;
    [HideInInspector]
    public static bool Bronze_Acquired = false;
    [HideInInspector]
    public static bool Bronze_Equipped = false;
    private void Start()
    {
        bronze_itemcost = GameObject.Find("Bronze Item Cost").GetComponent<Text>();
    }

    void Update()
    {
        if(Total_Clickpoints >= BronzeItem_Cost && LevelSystem_P1.Level >= 2)
        {
            Bronze_Acquired = true;
        }
        if (BronzeItem_System.Bronze_Acquired == true && BronzeItem_System.Bronze_Equipped == false)
        {
            bronze_itemcost.text = ("Equip");
        }
        else if (BronzeItem_System.Bronze_Acquired == true && BronzeItem_System.Bronze_Equipped == true)
        {
            bronze_itemcost.text = ("Unequip");
        }

    }
}
