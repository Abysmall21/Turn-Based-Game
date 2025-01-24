using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.InputSystem;

public class GameManager : MonoBehaviour
{
    public GameObject grass;
    public GameObject cube;

    

    InputAction clickAction;

    // Start is called before the first frame update
    void Start()
    {
        

        grass.GetComponent<SpriteRenderer>().color = Color.red;
        StartCoroutine(DeadTime());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    

    
    IEnumerator DeadTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);
            cube.GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value);
        }
    }
}
