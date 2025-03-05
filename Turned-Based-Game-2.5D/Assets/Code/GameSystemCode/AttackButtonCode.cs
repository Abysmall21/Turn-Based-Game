using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AttackButtonCode : MonoBehaviour
{
    public Button AttackButton;
    public GameObject PlayerTWO;
    
    public void Attack()
    {
        PlayerTWO.GetComponentInChildren<UnitController>().UnitHealth -= 5;
    }
}
