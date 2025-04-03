using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ItemList : MonoBehaviour
{
    public Item[] item;
    public Text[] text;
    // Start is called before the first frame update
    void Start()
    {
        SetItemText(item);
    }
    void SetItemText(Item[] item)
    {
        foreach (Item i in item)
        {
            for(int a = 0; a < 3; a ++)
            {
                text[a].text = i.Name.ToString();
            }
        }
    }
    void PlayAciton()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
