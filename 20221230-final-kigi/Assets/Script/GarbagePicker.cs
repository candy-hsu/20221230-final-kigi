using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GarbagePicker : MonoBehaviour
{
    public GameObject trashCan;
    public GameObject player;
   
    //public string garbageModelString;

   
    public AudioClip trashCanSfx;
    public ParticleSystem Explosion;


    public float pickupDistance = 2;

   
    void Update()
    {
        //Ray ray = new Ray(player.transform.position, player.transform.forward);
        //RaycastHit hit;
        //if (Physics.Raycast(ray, out hit, pickupDistance))
        //{
        // if (hit.collider.gameObject == garbageModel)
        // {


        // }
        //}

        // if (player.GetComponent<Collider>().bounds.Intersects(trashCan.GetComponent<Collider>().bounds))
        //{
        // AudioSource.PlayClipAtPoint(trashCanSfx, player.transform.position);
        // garbageCount = 0;
        //}

        if (player.GetComponent<Collider>().bounds.Intersects(trashCan.GetComponent<Collider>().bounds))
        {
            AudioSource.PlayClipAtPoint(trashCanSfx, trashCan.transform.position);
            Explosion.Play();
           // garbageCount = 0;
        }
    }
}
