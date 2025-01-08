using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class UnitController : MonoBehaviour
{
    public GameObject[] Sprite;
    public UnitStatList _UnitStatList;

    public int UnitHealth = 0;
    public int UnitMaxHealth = 0;

    // Start is called before the first frame update
    void Start()
    {
        UnitMaxHealth = _UnitStatList.Health * Sprite.Length;
        UnitHealth = UnitMaxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            UnitHealth = UnitHealth - 10;
            
        }
        UnitPopHealth();
    }
    void UnitPopHealth()
    {
        if (UnitHealth == 0)
        {
            gameObject.SetActive(false);
            
        }
    }
}
