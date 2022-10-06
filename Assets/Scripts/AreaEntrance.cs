using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaEntrance : MonoBehaviour
{

    public string areaComingFrom;

    // Start is called before the first frame update
    void Start()
    {
        if (areaComingFrom == PlayerController.instance.areaComingFrom)
        {
            PlayerController.instance.transform.position = transform.position;
            LevelManager.instance.SetCheckpoint(transform.position);
        }

        UIFade.instance.FadeFromBlack();
    }

    // Update is called once per frame
    void Update()
    {
    }
}
