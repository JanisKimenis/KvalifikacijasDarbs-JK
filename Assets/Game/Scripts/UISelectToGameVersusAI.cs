using UnityEngine;
using UnityEngine.UI;


public class UISelectToGameVersusAI : MonoBehaviour
{

    public enum Difficulty { Easy = 0, Normal = 1, Hard = 2 }
    public enum BattleBotType { Mage1 = 0, Mage2 = 1, Explo1 = 2, Explo2 = 3 }
    public Difficulty selectedDifficulty;
    public BattleBotType playerSelectedBattleBotType;
    public BattleBotType enemySelectedBattleBotType;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        selectedDifficulty = Difficulty.Normal; // Set default difficulty
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnDifficultyButtonClicked(int difficultyIndex)
    {
        selectedDifficulty = (Difficulty)difficultyIndex;
        Debug.Log("Selected Difficulty: " + selectedDifficulty);
    }
    public void OnPlayerBattleBotButtonClicked(int battleBotIndex)
    {
        playerSelectedBattleBotType = (BattleBotType)battleBotIndex;
        Debug.Log("Player Selected Battle Bot: " + playerSelectedBattleBotType);
    }
    public void GetEnemyBattleBotType()
    {
        // Randomly select an enemy Battle Bot type
        if (playerSelectedBattleBotType == BattleBotType.Mage1 || playerSelectedBattleBotType == BattleBotType.Mage2)
        {
            // If player selected a Mage, enemy will be an Explo
            enemySelectedBattleBotType = (Random.value > 0.5f) ? BattleBotType.Explo1 : BattleBotType.Explo2;
        }
        else
        {
            // If player selected an Explo, enemy will be a Mage
            enemySelectedBattleBotType = (Random.value > 0.5f) ? BattleBotType.Mage1 : BattleBotType.Mage2;
        }
    }
}
