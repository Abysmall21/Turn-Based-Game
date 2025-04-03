using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Ablity
{
    public enum Action { Heal,Damage,Reduce }

    public void Set(Action action)
    {
        switch(action)
        {
            case Action.Heal: Heal();
                break;
            case Action.Damage: Damage();
                break;
            case Action.Reduce: Reduce();
                break;
        }
    }

    public void Heal()
    {
        Debug.Log("Heal");
    }
    public void Damage()
    {
        Debug.Log("Damage");
    }
    public void Reduce()
    {
        Debug.Log("Reduce");
    }
}
