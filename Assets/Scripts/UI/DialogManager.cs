using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.InputSystem;

public class DialogManager : MonoBehaviour
{
    public static DialogManager instance;

    public TMP_Text dialogText, speakerText;
    public GameObject dialogBox, speakerBox;

    public string[] dialogLines;
    public int currentLine;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        //dialogText.text = dialogLines[currentLine];
    }

    // Update is called once per frame
    void Update()
    {
    }


    public void dialogForward(InputAction.CallbackContext context)
    {

        /*if (DialogActivator.instance.canActivate && context.performed)
        {
            ShowDialog(DialogActivator.instance.lines);
        } */

        //Debug.Log("Pressed a key from Dialog Manager");
        if (dialogBox.activeInHierarchy && context.performed)
        {
            currentLine++;
            if (currentLine >= dialogLines.Length)
            {
                dialogBox.SetActive(false);
                PlayerController.instance.playerInput.SwitchCurrentActionMap("Player");
            }
            else
            {
                CheckIfName();
                dialogText.text = dialogLines[currentLine];
            }
        }
        
    }


    public void ShowDialog(string[] newLines, bool isPerson)
    {
        dialogLines = newLines;
        currentLine = 0;
        CheckIfName();
        dialogText.text = dialogLines[currentLine];
        dialogBox.SetActive(true);

        speakerBox.SetActive(isPerson);
    }

    public void CheckIfName()
    {
        if (dialogLines[currentLine].StartsWith("n-"))
        {
            speakerText.text = dialogLines[currentLine].Replace("n-", "");
            currentLine++;
        }
    }

}
