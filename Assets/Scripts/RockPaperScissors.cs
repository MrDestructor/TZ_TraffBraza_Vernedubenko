using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RockPaperScissors : MonoBehaviour
{
    [Header("Sprite Choices")]
    public Sprite Rock, Paper, Scissors, Other;

    [Header("Name")]
    public string[] NameChoice;

    [Header("UI")]
    public Image DragonChoiceImage;
    public Text TieText;

    private BattleLogic battleLogic;

    private void Start()
    {
        battleLogic = GetComponent<BattleLogic>();
        TieText.text = string.Empty;
    }

    public void ClickActions(string choise)
    {
        var randomDragonChoice = NameChoice[Random.Range(0, NameChoice.Length)];

        if (battleLogic.CurrentCharacterHealth >= 0 || battleLogic.CurrentDragonHealth >= 0)
        {
            switch (randomDragonChoice)
            {
                case "Rock":
                    switch (choise)
                    {
                        case "Rock":
                            TieText.text = "Tie!";
                            break;

                        case "Paper":
                            battleLogic.DragonHit(10);
                            break;

                        case "Scissors":
                            battleLogic.CharacterHit(10);
                            break;

                    }

                    DragonChoiceImage.sprite = Rock;
                    break;

                case "Paper":
                    switch (choise)
                    {
                        case "Rock":
                            battleLogic.CharacterHit(10);
                            break;

                        case "Paper":
                            TieText.text = "Tie!";
                            break;

                        case "Scissors":
                            battleLogic.DragonHit(10);
                            break;

                    }

                    DragonChoiceImage.sprite = Paper;
                    break;

                case "Scissors":
                    switch (choise)
                    {
                        case "Rock":
                            battleLogic.DragonHit(10);
                            break;

                        case "Paper":
                            battleLogic.CharacterHit(10);
                            break;

                        case "Scissors":
                            TieText.text = "Tie!";
                            break;

                    }

                    DragonChoiceImage.sprite = Scissors;
                    break;

            }
        }
    }
}
