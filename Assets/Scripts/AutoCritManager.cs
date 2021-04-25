using UnityEngine;

public class AutoCritManager : MonoBehaviour
{
    private CriticalFunction CriticalFunction;
    private CriticalHit_System CriticalHit_System;
    [SerializeField]
    private AutoCritUpgrade AutoCritUpgrade;
    // Start is called before the first frame update
    void Start()
    {
        CriticalHit_System = GetComponent<CriticalHit_System>();
        CriticalFunction = GetComponentInChildren<CriticalFunction>();
    }

    public void AutoCritTime()
    {
        if(CriticalHit_System.CriticalHitChance == 1 && AutoCritUpgrade.AutoCritEquipped == 1)
        {
            CriticalFunction.CriticalHit();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
