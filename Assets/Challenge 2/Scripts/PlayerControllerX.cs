using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float coolDown = 0.7f;
    private float lastSpawn = 0.0f;

    // Update is called once per frame
    void Update()
    {
        //will add 1 second evry time it passes using the time feature 
        lastSpawn += Time.deltaTime;
        // On spacebar press, send dog , if last spawn is less than cooldown a dog will not spawn
        if (Input.GetKeyDown(KeyCode.Space) && lastSpawn > coolDown)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            //reset spawn cooldown timer
            lastSpawn = 0.0f;
        }
    }
}
