using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Monster", menuName = "Monster/Create New Monster")]
public class MonsterBase : ScriptableObject
{
    [SerializeField] string monName;

    [TextArea]
    [SerializeField] string description;

    [SerializeField] Sprite sprite;

    [SerializeField] MonsterClass monClass1;
    [SerializeField] MonsterClass monClass2;
    [SerializeField] MonsterRank monRank;
    [SerializeField] MonsterSize monSize;

    //Base Stats
    [SerializeField] int maxHP;
    [SerializeField] int maxMP;
    [SerializeField] int attack;
    [SerializeField] int defense;
    [SerializeField] int magAttack;
    [SerializeField] int magDefense;
    [SerializeField] int agility;
    [SerializeField] int luck;

    [SerializeField] List<StartingSkillTrees> startingSkillTrees;

    public string MonName
    {
        get {return monName;}
    }

    public string Description
    {
        get { return description; }
    }

    public Sprite Sprite
    {
        get { return sprite; }
    }

    public MonsterClass MonClass1
    {
        get { return monClass1; }
    }

    public MonsterClass MonClass2
    {
        get { return monClass2; }
    }

    public MonsterRank MonRank
    {
        get { return monRank; }
    }

    public MonsterSize MonSize
    {
        get { return monSize; }
    }

    public int MaxHP
    {
        get { return maxHP; }
    }

    public int MaxMP
    {
        get { return maxMP; }
    }

    public int Attack
    {
        get { return attack; }
    }

    public int Defense
    {
        get { return defense; }
    }

    public int MagAttack
    {
        get { return magAttack; }
    }

    public int MagDefense
    {
        get { return magDefense; }
    }

    public int Agility
    {
        get { return agility; }
    }

    public int Luck
    {
        get { return luck; }
    }


    public List<StartingSkillTrees> StartingSkillTrees
    {
        get { return startingSkillTrees; }
    }
}

[System.Serializable]
public class StartingSkillTrees 
{
    [SerializeField] SkillTreeTemplate tree;

    public SkillTreeTemplate Tree
    {
        get { return tree;  }
    }
}



public enum MonsterClass 
{
    None,
    Abberation,
    Beast,
    Celestial,
    Construct,
    Dragon,
    Elemental,
    Fiend,
    Monstrosity,
    Plant,
    Undead
}

public enum MonsterRank
{
    F,
    E,
    D,
    C,
    B,
    A,
    S
}

public enum MonsterSize 
{
    Medium,
    Large,
    Huge,
    Massive
}
