using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleLogic : MonoBehaviour
{
    public int CurrentCharacterHealth { get; private set; }  // Character's current health
    public int CurrentDragonHealth { get; private set; }  // Dragon's current health

    [Header("HealthLine")]
    public Slider SliderCharacterHealth;  // Character health slider
    public Slider SliderDragonHealth;  // Âêôïùò health slider

    [Header("Result")]
    public Text TextResult;  // text for the GameOver panel

    private int maxCharacterHealth = 100;
    private int maxDragonHealth = 100;

    private void Start()
    {
        CurrentCharacterHealth = maxCharacterHealth;
        CurrentDragonHealth = maxDragonHealth;

        SliderCharacterHealth.maxValue = maxCharacterHealth;
        SliderDragonHealth.maxValue = maxDragonHealth;

        SliderCharacterHealth.value = CurrentCharacterHealth;
        SliderDragonHealth.value = CurrentDragonHealth;

        TextResult.text = string.Empty;
    }

    private void Update()
    {
        ResultButtle();
    }

    public void CharacterHit(int health)  // The method of taking damage for the character
    {
        if(CurrentCharacterHealth >= 0)
            CurrentCharacterHealth -= health;

        SliderCharacterHealth.value = CurrentCharacterHealth;
    }

    public void DragonHit(int health)  // The method of taking damage for the dragon
    {
        if (CurrentDragonHealth >= 0)
            CurrentDragonHealth -= health;

        SliderDragonHealth.value = CurrentDragonHealth;
    }

    public void ResultButtle()  // Method for determining the result at the end of health for characters
    {
        if (CurrentDragonHealth <= 0 && CurrentCharacterHealth > 0)
            TextResult.text = "You Win!";

        if (CurrentCharacterHealth <= 0 && CurrentDragonHealth > 0)
            TextResult.text = "You Lose!";

        if(CurrentCharacterHealth <= 0 && CurrentDragonHealth <= 0)
            TextResult.text = "Tie!";
    }
}
