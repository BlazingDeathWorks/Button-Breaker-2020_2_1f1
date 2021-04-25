using UnityEngine;
using UnityEngine.UI;
public class DefaultItem_System : MonoBehaviour
{
    public static bool Default_Acquired = true;
    public static bool Default_Equipped = true;
    [SerializeField]
    private Text defaultitem_cost;

    // Start is called before the first frame update
    void Start()
    {
        defaultitem_cost = GameObject.Find("Default Item Cost").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        Default_Acquired = true;
        if (Default_Acquired == true && Default_Equipped == false)
        {
            defaultitem_cost.text = ("Equip");
        }
        else if(Default_Acquired == true && Default_Equipped == true)
        {
            defaultitem_cost.text = ("Unequip");
        }
    }
}
