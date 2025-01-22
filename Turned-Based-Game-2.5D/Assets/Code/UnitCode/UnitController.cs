using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class UnitController : MonoBehaviour
{
    public GameObject[] Sprite; //Sprite Models
    public UnitStatList _UnitStatList; //Unit Stat list

    public bool IsSelected; //if player click on

    [Header("Unit Heal")]
    public int UnitHealth = 0; // Current health
    public int UnitMaxHealth = 0; // Max health

    // Start is called before the first frame update
    void Start()
    {
        UnitMaxHealth = _UnitStatList.Health * Sprite.Length;
        UnitHealth = UnitMaxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (IsSelected) //when player click on unit
        {   
            Debug.Log("Click on " + name);
        }
        if (Input.GetKeyDown(KeyCode.E)) //Test for Damaged
        {
            UnitHealth = UnitHealth - 10;
            foreach (var item in Sprite)
            {
                for (int i = 0; i < Sprite.Length; i++)
                {
                    Sprite[i].GetComponent<SpriteRenderer>().color = Color.red;
                }
            }
            

        }
        else if (Input.GetKeyDown(KeyCode.S)) //test Healing and 
        {
            UnitHealth = UnitHealth + 10;
            foreach (GameObject item in Sprite)
            {
                for(int i = 0; i < Sprite.Length; i++)
                {
                    Sprite[i].GetComponent<SpriteRenderer>().color = Color.green;   
                }
            }
        }
        else
        {
            foreach (var item in Sprite)
            {
                for (int i = 0; i < Sprite.Length; i++)
                {
                    Sprite[i].GetComponent<SpriteRenderer>().color = Color.white;
                }
            }
        }
        UnitPopHealth();
    }
    void UnitPopHealth() //Control how many models are live on in the unit
    {
        if(UnitHealth > UnitMaxHealth) //Rest Health if it goes past it's max
        {
            UnitHealth = UnitMaxHealth;
        }
        if (UnitHealth <= 0) //Kill Unit when heal = 0
        {
            gameObject.SetActive(false);
            Debug.Log("Unit Died");
        }
    }
    IEnumerator DeadTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);
            
        }
    }
}
