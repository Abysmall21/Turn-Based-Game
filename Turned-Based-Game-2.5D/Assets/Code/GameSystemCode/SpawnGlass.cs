using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnGlass : MonoBehaviour
{
    public GameObject Grass;
    public Desenty desenty;
    [Header("Spawn Gird")]
    public int x = 10;
    public int y = 10;
    // Start is called before the first frame update
    void Start()
    {
        CreateGrass();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void CreateGrass()
    {
        int a = 1;
        switch (desenty)
        {
            case Desenty.low: 
                a = 5;
                break;
            case Desenty.mid:
                a = 10;
                break;
            case Desenty.high:
                a = 20;
                break;
        }
        for (int i = 0;  i > a; i++)
        {
            Vector3 pos = new Vector3(Random.Range(-x,x),Random.Range(-y,y), a);
            Grass.transform.position = pos;
            Grass = Instantiate(Grass,Grass.transform);
            Grass.transform.position = pos;
        }

    }

    public enum Desenty
    {
        low,mid,high
    }

}
