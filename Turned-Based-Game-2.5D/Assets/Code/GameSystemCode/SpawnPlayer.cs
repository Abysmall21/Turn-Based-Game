using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlayer : MonoBehaviour
{
    Transform pos;
    public GameObject Player;

    public Dir direct;

    

    // Start is called before the first frame update
    void Start()
    {
        pos = this.transform;

        CreatePlayer();


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CreatePlayer()
    {
        Player = Instantiate(Player, pos);
        switch (direct)
        {
            case Dir.left:
                Player.transform.localScale = new Vector3(1, 1, 1);
                    break;
            case Dir.right:
                Player.transform.localScale = new Vector3(-1, 1, 1);
                    break;
        }
    }
    public enum Dir
    {
        left, right
    }
}

