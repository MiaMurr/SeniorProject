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
    [SerializeField] private InputActionReference MoveUP = null;
    [SerializeField] private TMP_Text displayButtion = null;
    private InputActionRebindingExtensions.RebindingOperation rebindingOperation;

    private void Start()
    {
    }
    void OnMouseUpAsButton()
    {
        Rebinding();
    }
    void Rebinding()
    {
        RebindButtion.SetActive(false);
        Rebindingwaiting.SetActive(true);
        input.SwitchCurrentActionMap("Menu");

        rebindingOperation = MoveUP.action.PerformInteractiveRebinding()
            .OnMatchWaitForAnother(0.1f)
            .WithControlsExcluding("Mouse")
            .OnComplete(operation => RebindDone())
            .Start();
    }

    private void RebindDone()
    {
        int BidingIndex = MoveUP.action.GetBindingIndexForControl(MoveUP.action.controls[0]);
        displayButtion.text = InputControlPath.ToHumanReadableString(MoveUP.action.bindings[BidingIndex].effectivePath,
            InputControlPath.HumanReadableStringOptions.OmitDevice);


        RebindButtion.SetActive(true);
        Rebindingwaiting.SetActive(false);
        input.SwitchCurrentActionMap("MenuGameplay");
        rebindingOperation.Dispose();
    }
}
