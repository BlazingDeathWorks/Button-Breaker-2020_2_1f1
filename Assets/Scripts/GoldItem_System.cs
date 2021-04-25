using UnityEngine;
using UnityEngine.UI;

public class GoldItem_System : MonoBehaviour
{
    public static int GoldItem_Cost = 1800;
    public static bool Gold_Acquired = false;
    public static bool Gold_Equipped = false;
    [SerializeField]
    private Text golditem_cost;
    // Start is called before the first frame update
    void Start()
    {
        golditem_cost = GameObject.Find("Gold Item Cost").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if(BronzeItem_System.Total_Clickpoints >= GoldItem_Cost && LevelSystem_P1.Level >= 4)
        {
            Gold_Acquired = true;
        }
        if(Gold_Acquired == true && Gold_Equipped == false)
        {
            golditem_cost.text = ("Equip");
        }
        else if(Gold_Acquired == true && Gold_Equipped == true)
        {
            golditem_cost.text = ("Unequip");
        }
    }
}
