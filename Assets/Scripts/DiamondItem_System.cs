using UnityEngine;
using UnityEngine.UI;

public class DiamondItem_System : MonoBehaviour
{
    public static int DiamondItem_Cost = 8000;
    public static bool Diamond_Acquired = false;
    public static bool Diamond_Equipped = false;
    [SerializeField]
    private Text diamonditem_cost;

    void Start()
    {
        diamonditem_cost = GameObject.Find("Diamond Item Cost").GetComponent<Text>();
    }

    void Update()
    {
        if(BronzeItem_System.Total_Clickpoints >= DiamondItem_Cost && LevelSystem_P1.Level >= 5)
        {
            Diamond_Acquired = true;
        }
        if(Diamond_Acquired == true && Diamond_Equipped == false)
        {
            diamonditem_cost.text = ("Equip");
        }
        else if(Diamond_Acquired == true && Diamond_Equipped == true)
        {
            diamonditem_cost.text = ("Unequip");
        }
    }

}
