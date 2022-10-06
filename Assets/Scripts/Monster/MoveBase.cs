using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Move", menuName = "Monster/Create New Move")]
public class MoveBase : ScriptableObject
{

    [SerializeField] string moveName;

    [TextArea]
    [SerializeField] string description;

    [SerializeField] DamageType type1;
    [SerializeField] DamageType type2;
    [SerializeField] int power;
    [SerializeField] int accuracy;
    [SerializeField] int mpCost;

    [SerializeField] int levelReq;


    public string MoveName
    {
        get
        {
            return moveName;
        }
    }

    public string Description
    {
        get
        {
            return description;
        }
    }

    public DamageType Type1
    {
        get
        {
            return type1;
        }
    }

    public DamageType Type2
    {
        get
        {
            return type2;
        }
    }

    public int Power
    {
        get
        {
            return power;
        }
    }

    public int Accuracy
    {
        get
        {
            return accuracy;
        }
    }

    public int MpCost
    {
        get
        {
            return mpCost;
        }
    }

    public int LevelReq
    {
        get
        {
            return levelReq;
        }
    }

}




public enum DamageType
{
    None,
    Physical,
    Magic,
    Fire,
    Earth,
    Water,
    Air,
    Light,
    Dark
}
