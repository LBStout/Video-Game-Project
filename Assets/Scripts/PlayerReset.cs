using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerReset : MonoBehaviour
{

    public static PlayerReset instance;

    public float waitTime;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            PlayerController.instance.Knockback();
            StartCoroutine(RespawnCo(waitTime));
        }
    }

    private IEnumerator RespawnCo(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);

        //PlayerController.instance.sr.color = new Color(PlayerController.instance.sr.color.r, PlayerController.instance.sr.color.g, PlayerController.instance.sr.color.b, 0f);
        //PlayerController.instance.isControllable = false;
        //Debug.Log("Respawn");

        PlayerController.instance.transform.position = LevelManager.instance.playerRespawnPoint;

        //PlayerController.instance.sr.color = new Color(PlayerController.instance.sr.color.r, PlayerController.instance.sr.color.g, PlayerController.instance.sr.color.b, 1f);

        PlayerController.instance.isControllable = true;

    }
}
