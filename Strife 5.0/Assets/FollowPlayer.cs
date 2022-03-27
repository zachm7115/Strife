using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    public Transform player;

    // Update is called once per frame
    void Update () {
        //Console.WriteLine("Camera Update Called")
        transform.position = player.position + new Vector3(0, 1, -5);
    }
}