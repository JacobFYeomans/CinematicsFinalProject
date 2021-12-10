using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class TriggerScript : MonoBehaviour
{
    public PlayableDirector timeline;
    public GameObject Player;

    public bool OneTimeTrigger = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            timeline.Play();
            Player.GetComponent<S_FPS_Move>().enabled = false;

            if (OneTimeTrigger == true)
            {

                Destroy(this.gameObject);

            }

        }
    }




}
