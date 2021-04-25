using UnityEngine;
using UnityEngine.UI;
public class ExplantionScript : MonoBehaviour
{
    [SerializeField]
    private Image Explanation;
    [SerializeField]
    private Text title;
    private bool Explanation_IsActive = false;
    [SerializeField]
    private Text Brief;

    // Start is called before the first frame update
    void Start()
    {
        Explanation = GameObject.Find("Player Health Explanation").GetComponent<Image>();
        Brief = GameObject.Find("Explanation Briefly").GetComponent<Text>();
        title = GameObject.Find("Title").GetComponent<Text>();
    }


    public void ExplanationSwitch()
    {
        Explanation_IsActive = !Explanation_IsActive;
    }

    // Update is called once per frame
    void Update()
    {
        if(Explanation_IsActive == false)
        {
            title.enabled = false;
            Explanation.enabled = false;
            Brief.enabled = false;
        }
        else if(Explanation_IsActive == true)
        {
            title.enabled = true;
            Explanation.enabled = true;
            Brief.enabled = true;
        }
    }
}
