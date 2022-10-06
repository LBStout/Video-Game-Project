using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleUnit : MonoBehaviour
{
    [SerializeField] MonsterBase monBase;
    [SerializeField] int level;
    [SerializeField] int rank;
    [SerializeField] int size;
    private Animator anim;

    private void Awake()
    {
        anim = GetComponent<Animator>();
    }

    public Monster Pokemon { get; set; }

    public void Setup()
    {
        Pokemon = new Monster(monBase, level, rank, size);
        GetComponent<Image>().sprite = Pokemon.monBase.Sprite;

    }

    public void Fade()
    {
        anim.SetBool("isSelected", true);
    }

    public void UnFade()
    {
        anim.SetBool("isSelected", false);
    }
}
