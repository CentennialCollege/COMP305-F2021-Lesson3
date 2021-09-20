using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public Transform player;
    public Transform spawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        player.position = spawnPoint.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
