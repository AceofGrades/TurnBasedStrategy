using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionSelectionState : BaseAbilityMenuState
{
    public static int category;
    string[] firstAidOptions = new string[] { "Medkit", "Rez-Aid" };
    string[] techniqueOptions = new string[] { "Lightning Shot", "Assault Rifle", "Shotgun" };
    protected override void LoadMenu()
    {
        if (menuOptions == null)
            menuOptions = new List<string>(3);
        if (category == 0)
        {
            menuTitle = "First Aid";
            SetOptions(firstAidOptions);
        }
        else
        {
            menuTitle = "Techniques";
            SetOptions(techniqueOptions);
        }
        abilityMenuPanelController.Show(menuTitle, menuOptions);
    }
    protected override void Confirm()
    {
        turn.hasUnitActed = true;
        if (turn.hasUnitMoved)
            turn.lockMove = true;
        owner.ChangeState<CommandSelectionState>();
    }
    protected override void Cancel()
    {
        owner.ChangeState<CategorySelectionState>();
    }
    void SetOptions(string[] options)
    {
        menuOptions.Clear();
        for (int i = 0; i < options.Length; ++i)
            menuOptions.Add(options[i]);
    }
}
