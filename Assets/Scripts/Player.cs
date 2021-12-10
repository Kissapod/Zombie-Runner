using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Transform playerSpawnPoints;
    public bool reSpawn = false;
    public GameObject landingArea;

    private Transform[] spawnPoints;
    private bool lastToggle = false;
    // Start is called before the first frame update
    void Start()
    {
        spawnPoints = playerSpawnPoints.GetComponentsInChildren<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (lastToggle != reSpawn)
        {
            ReSpawn();
            reSpawn = false;
        } else
        {
            lastToggle = reSpawn;
        }
    }

    void ReSpawn()
    {
        int i = Random.Range(1, spawnPoints.Length);
        GetComponent<CharacterController>().enabled = false;
        transform.position = spawnPoints[i].transform.position;
        GetComponent<CharacterController>().enabled = true;
    }

    void OnFindClearArea()
    {
        Debug.Log("Используем ракетницу для вызова");
        Invoke(nameof(DropFlare), 3f);
    }

    void DropFlare()
    {
        Vector3 landingAreaPos = FindObjectOfType<ClearArea>().landingAreaCoor;
        Instantiate(landingArea, landingAreaPos, Quaternion.identity);
    }
}

