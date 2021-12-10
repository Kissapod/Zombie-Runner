using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearArea : MonoBehaviour
{
    public float timeSinceLastTrigger = 0f;
    [HideInInspector] public Vector3 landingAreaCoor;

    private bool foundClearArea = false;

    // Update is called once per frame
    void Update()
    {
        timeSinceLastTrigger += Time.deltaTime;

        if (timeSinceLastTrigger > 3f && Time.realtimeSinceStartup > 10f && !foundClearArea)
        {
            Debug.Log("Активируем вызов вертолета");
            SendMessageUpwards("OnFindClearArea");
            landingAreaCoor = FindObjectOfType<Player>().transform.position;
            foundClearArea = true;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        //if (!other.CompareTag("Player"))
      // {
            timeSinceLastTrigger = 0f;
       // }
    }
}
