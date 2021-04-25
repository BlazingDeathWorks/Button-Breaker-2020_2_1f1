using UnityEngine;
using UnityEngine.UI;

public class SilverItem_System : MonoBehaviour
{
    [HideInInspector]
    public static int SilverItem_Cost = 1200;
    [HideInInspector]
    public static bool Silver_Acquired = false;
    [HideInInspector]
    public static bool Silver_Equipped = false;
    [SerializeField]
    private Text silveritem_cost;


    void Start()
    {
        silveritem_cost = GameObject.Find("Silver Item Cost").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if(BronzeItem_System.Total_Clickpoints >= SilverItem_Cost && LevelSystem_P1.Level >= 3)
        {
            Silver_Acquired = true;
        }
        if(Silver_Acquired == true && Silver_Equipped == false)
        {
            silveritem_cost.text = ("Equip");
        }
        else if(Silver_Acquired == true && Silver_Equipped == true)
        {
            silveritem_cost.text = ("Unequip");
        }

    }
}
