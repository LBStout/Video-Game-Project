using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BattleDialogBox : MonoBehaviour
{
    [SerializeField] TMP_Text dialogText;
    [SerializeField] GameObject actionSelector;
    [SerializeField] GameObject moveSelector;
    [SerializeField] GameObject moveDetails;

    [SerializeField] List<TMP_Text> actionTexts;
    [SerializeField] List<TMP_Text> moveTexts;

    [SerializeField] TMP_Text type1Text;
    [SerializeField] TMP_Text type2Text;
    [SerializeField] TMP_Text powerText;
    [SerializeField] TMP_Text accText;
    [SerializeField] TMP_Text mpText;



    public void SetDialog(string dialog)
    {
        dialogText.text = dialog;
    }
}
