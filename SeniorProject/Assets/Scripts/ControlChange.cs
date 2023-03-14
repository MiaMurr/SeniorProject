using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.Build;
using UnityEngine;
using UnityEngine.InputSystem;

public class ControlChange : MonoBehaviour
{
    [SerializeField] private PlayerInput input = null;
    [SerializeField] private GameObject RebindButtion = null;
    [SerializeField] private GameObject Rebindingwaiting = null;
    [SerializeField] private InputActionReference MoveAction = null;
    [SerializeField] private TMP_Text displayButtion = null;
    [SerializeField] private string Changetmapping = "Menu";
    [SerializeField] private string backmapping = "MenuGameplay";
    public bool Composet = false;
    public int rebindNum = 0;
    private InputActionRebindingExtensions.RebindingOperation rebindingOperation;

    private void Start()
    {
        //RebindDone();
    }
    void OnMouseUpAsButton()
    {
        Rebinding();
    }
    void Rebinding()
    {
        if (Composet == false)
        {
            RebindButtion.SetActive(false);
            Rebindingwaiting.SetActive(true);
            input.SwitchCurrentActionMap(Changetmapping);
            rebindingOperation = MoveAction.action.PerformInteractiveRebinding()

                .OnMatchWaitForAnother(0.1f)
                .WithControlsExcluding("Mouse")
                .OnComplete(operation => RebindDone())
                .Start();
        }
        else
        {
            RebindButtion.SetActive(false);
            Rebindingwaiting.SetActive(true);
            input.SwitchCurrentActionMap(Changetmapping);
            rebindingOperation = MoveAction.action.PerformInteractiveRebinding()
                .WithTargetBinding(rebindNum)
                .OnMatchWaitForAnother(0.1f)
                .WithControlsExcluding("Mouse")
                .OnComplete(operation => RebindDone())
                .Start();
        }
    }

    private void RebindDone()
    {
        //int BidingIndex = MoveAction.action.GetBindingIndexForControl(MoveAction.action.controls[rebindNum]);
        //Debug.Log(BidingIndex);
        displayButtion.text = InputControlPath.ToHumanReadableString(MoveAction.action.bindings[rebindNum].effectivePath,
            InputControlPath.HumanReadableStringOptions.OmitDevice);


        RebindButtion.SetActive(true);
        Rebindingwaiting.SetActive(false);
        input.SwitchCurrentActionMap(backmapping);
        rebindingOperation.Dispose();
    }
}
