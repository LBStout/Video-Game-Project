using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Skill Tree", menuName = "Monster/Create New Skill Tree")]
public class SkillTreeTemplate : ScriptableObject
{
    [SerializeField] string treeName;

    [TextArea]
    [SerializeField] string description;

    [SerializeField] List<skillList> skills;

    //Getter and Setter for all fields
    public string TreeName
    {
        get { return treeName; }
    }

    public string Description
    {
        get { return description; }
    }

    public List<skillList> Skills
    {
        get { return skills; }
    }

}

[System.Serializable]
public class skillList
{
    [SerializeField] MoveBase skill;

    public MoveBase Skill
    {
        get { return skill; }
    }

}
