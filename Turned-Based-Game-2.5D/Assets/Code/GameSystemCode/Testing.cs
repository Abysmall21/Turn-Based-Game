using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey.Utils;

public class Testing : MonoBehaviour
{
    private GridSystem gridSystem;

    // Start is called before the first frame update
    void Start()
    {
        gridSystem = new GridSystem(4, 2, 10f);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            gridSystem.SetValue(UtilsClass.GetMouseWorldPosition(), 56);
        }
    }
}
