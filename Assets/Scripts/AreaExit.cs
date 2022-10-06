using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AreaExit : MonoBehaviour
{

    public string areaToLoad, currentArea; //areaToLoad is the destination scene, currentArea is the current Scene

    public AreaEntrance theEntrance;

    public float waitToLoad = 1f;
    private bool shouldLoadAfterFade;

    // Start is called before the first frame update
    void Start()
    {
        theEntrance.areaComingFrom = areaToLoad;
    }

    // Update is called once per frame
    void Update()
    {
       /* if (shouldLoadAfterFade)
        {
            waitToLoad -= Time.deltaTime;
            if (waitToLoad <= 0)
            {
                shouldLoadAfterFade = false;
                SceneManager.LoadScene(areaToLoad);
            }
        } */
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            if (!SceneManager.GetSceneByName(areaToLoad).isLoaded)
            {
                SceneManager.LoadSceneAsync(areaToLoad, LoadSceneMode.Additive);
            }
            
            //shouldLoadAfterFade = true;
            //UIFade.instance.FadeToBlack();
            PlayerController.instance.areaComingFrom = currentArea;
        }
    }
}
