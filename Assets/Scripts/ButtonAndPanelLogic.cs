using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonAndPanelLogic : MonoBehaviour
{
    private BattleLogic battleLogic;

    [SerializeField]
    private Button[] button;
    [SerializeField]
    private GameObject gameOverPanel;
    [SerializeField]
    private Text TieText;

    private void Start()
    {
        battleLogic = GetComponent<BattleLogic>();

        ButtonOn();

        gameOverPanel.SetActive(false);
    }

    private void Update()
    {
        // Turn off the buttons and call the panel GameOver

        if (battleLogic.CurrentCharacterHealth <= 0 || battleLogic.CurrentDragonHealth <= 0)
        {
            ButtonOff();

            gameOverPanel.SetActive(true);
        }
    }

    public void ButtonOn() // Button enable method
    {
        for (int i = 0; i < button.Length; i++)
        {
            button[i].interactable = true;
        }

        TieText.text = string.Empty;
    }

    public void ButtonOff() // Button off method
    {
        for (int i = 0; i < button.Length; i++)
        {
            button[i].interactable = false;
        }
    }
}
