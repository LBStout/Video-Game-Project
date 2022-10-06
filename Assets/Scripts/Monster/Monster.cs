using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster
{
    public MonsterBase monBase { get; set; }
    public int level { get; set; }
    public int hp { get; set; }
    public int rank { get; set; }
    public int size { get; set; }

    public List<Move> Skills { get; set; }

    public Monster(MonsterBase mBase, int mLevel, int mRank, int mSize)
    {
        monBase = mBase;
        level = mLevel;
        rank = mRank;
        size = mSize;
        hp = MaxHP;

        Skills = new List<Move>();
        foreach (var tree in monBase.StartingSkillTrees)
        {
            foreach (var skill in tree.Tree.Skills)
            {
                if (skill.Skill.LevelReq <= level)
                {
                    Skills.Add(new Move(skill.Skill));
                }
            }
        }
    }


    public Sprite Sprite
    {
        get
        {
            return monBase.Sprite;
        }
    }

    public int MaxHP
    {
        get
        {
            return Mathf.FloorToInt(((monBase.MaxHP * level) / 100f) * ((rank + 1) * 0.5f) * (size + 1)) + 10;
        }
    }

    public int MaxMP
    {
        get
        {
            return Mathf.FloorToInt(((monBase.MaxMP * level) / 100f) * ((rank + 1) * 0.5f) * (size + 1)) + 5;
        }
    }


    public int Attack
    {
        get
        {
            return Mathf.FloorToInt(((monBase.Attack * level) / 100f) * ((rank + 1) * 0.5f) * (size + 1)) + 5;
        }
    }

    public int Defense
    {
        get
        {
            return Mathf.FloorToInt(((monBase.Defense * level) / 100f) * ((rank + 1) * 0.5f) * (size + 1)) + 5;
        }
    }

    public int MagAttack
    {
        get
        {
            return Mathf.FloorToInt(((monBase.MagAttack * level) / 100f) * ((rank + 1) * 0.5f) * (size + 1)) + 5;
        }
    }

    public int MagDefense
    {
        get
        {
            return Mathf.FloorToInt(((monBase.MagDefense * level) / 100f) * ((rank + 1) * 0.5f) * (size + 1)) + 5;
        }
    }

    public int Agility
    {
        get
        {
            return Mathf.FloorToInt(((monBase.Agility * level) / 100f) * ((rank + 1) * 0.5f) * (size + 1)) + 5;
        }
    }

    public int Luck
    {
        get
        {
            return Mathf.FloorToInt(((monBase.Luck * level) / 100f) * ((rank + 1) * 0.5f) * (size + 1)) + 5;
        }
    }

}

