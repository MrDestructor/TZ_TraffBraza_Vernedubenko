using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectedButtonScale : MonoBehaviour
{
    [SerializeField]
    private float timeSpane = 2f; // time for which the timer will run
    private float time;

    [SerializeField]
    private Button Button;

    [SerializeField]
    private Vector3 buttonScale; // how much to increase the button

    public ButtonAndPanelLogic buttonAndPanelLogic;

    private void Start()
    {
        time = timeSpane;
        Button.transform.localScale = new Vector3(1, 1 ,1);
    }

    private void FixedUpdate()
    {
        SelectedAction();
    }

    private void SelectedAction() // timer for turning on the buttons and returning the size of the buttons
    {
        if (timeSpane >= 0)
        {
            timeSpane -= Time.fixedDeltaTime;
        }
        else
        {
            buttonAndPanelLogic.ButtonOn();
            Button.transform.localScale = new Vector3(1, 1, 1);
            timeSpane = time;
        }
    }

    public void ScaleButton() // Enlarge the selected button in size and turn off the button 
    {
        Button.transform.localScale = buttonScale;
        buttonAndPanelLogic.ButtonOff();
    }
}
