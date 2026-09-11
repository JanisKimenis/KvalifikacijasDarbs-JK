using System;
using UnityEngine;

public class GameState : MonoBehaviour
{
    public gameState currentGameState = 0;



    public enum gameState
    {
        inMainMenu = 0,
        inCountdown = 1,
        inBattle = 2,
        inUpgrades = 3

    }
    public void ChangeGameState(int newGameStateIndex)
    {
        currentGameState = (gameState)newGameStateIndex;
    }

}
