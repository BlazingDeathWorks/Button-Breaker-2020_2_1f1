using UnityEngine;

public class EdoxButton : MonoBehaviour
{
    [HideInInspector]
    public bool EdoxSwitch = false;
    public GameObject LogCarrier;
    public void EdoxLogSwitch()
    {
        EdoxSwitch = !EdoxSwitch;
    }
    public void Update()
    {
        if(EdoxSwitch == false)
        {
            LogCarrier.SetActive(false);
        }
        else
        {
            LogCarrier.SetActive(true);
        }
    }


}
