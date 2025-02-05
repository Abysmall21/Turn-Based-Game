using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnManger //Our Turn Management System
{
    int turn;
    void StartGame()
    {
        turn = 1;
    }
    void NextTurn() //Code to Move to next turn
    {
        turn++;
    }
    void EndTurn() //Code to end turn
    {

    }
    void EndGame()
    {

    }
}
