using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class showKeyBinding : MonoBehaviour
{
    [SerializeField] private TMP_Text displayButtion = null;
    [SerializeField] private InputActionReference MoveAction = null;
    public int rebindNum = 0;
    // Start is called before the first frame update
    void Start()
    {
        displayButtion.text = InputControlPath.ToHumanReadableString(MoveAction.action.bindings[rebindNum].effectivePath,
            InputControlPath.HumanReadableStringOptions.OmitDevice);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
