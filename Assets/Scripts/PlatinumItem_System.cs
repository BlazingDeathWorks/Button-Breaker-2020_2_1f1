using UnityEngine;
using UnityEngine.UI;

public class PlatinumItem_System : MonoBehaviour
{
    public static int PlatinumItem_Cost = 2300;
    public static bool Platinum_Acquired = false;
    public static bool Platinum_Equipped = false;
    [SerializeField]
    private Text platinumitem_cost;

    // Start is called before the first frame update
    void Start()
    {
        platinumitem_cost = GameObject.Find("Platinum Item Cost").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if(BronzeItem_System.Total_Clickpoints >= PlatinumItem_Cost && LevelSystem_P1.Level >= 5)
        {
            Platinum_Acquired = true;
        }
        if(Platinum_Acquired == true && Platinum_Equipped == false)
        {
            platinumitem_cost.text = ("Equip");
        }
        else if(Platinum_Acquired == true && Platinum_Equipped == true)
        {
            platinumitem_cost.text = ("Unequip");
        }
    }
}
