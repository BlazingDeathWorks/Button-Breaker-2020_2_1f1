using UnityEngine;
using UnityEngine.UI;

public class TotalClickpoints : MonoBehaviour
{
    private Text totalclickpoints_actualtext;

    // Start is called before the first frame update
    void Start()
    {
        totalclickpoints_actualtext = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        totalclickpoints_actualtext.text = BronzeItem_System.Total_Clickpoints.ToString();
    }
}
