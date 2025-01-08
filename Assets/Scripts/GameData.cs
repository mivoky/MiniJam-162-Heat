using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameData : MonoBehaviour
{
    public int TotalScore;
    public bool IcePlayer = true;
    public bool EndGame = false;
    public void ChangeEndGame(bool endGame)
    {
        EndGame = endGame; 
    }
}
