using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleLogic : MonoBehaviour
{
    public int CurrentCharacterHealth { get; private set; }
    public int CurrentDragonHealth { get; private set; }

    [Header("HealthLine")]
    public Slider SliderCharacterHealth;
    public Slider SliderDragonHealth;

    [Header("Result")]
    public Text TextResult;

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

    public void CharacterHit(int health)
    {
        if(CurrentCharacterHealth >= 0)
            CurrentCharacterHealth -= health;

        SliderCharacterHealth.value = CurrentCharacterHealth;
    }

    public void DragonHit(int health)
    {
        if (CurrentDragonHealth >= 0)
            CurrentDragonHealth -= health;

        SliderDragonHealth.value = CurrentDragonHealth;
    }

    public void ResultButtle()
    {
        if (CurrentDragonHealth <= 0)
            TextResult.text = "You Win!";

        if (CurrentCharacterHealth <= 0)
            TextResult.text = "You Lose!";
    }
}
