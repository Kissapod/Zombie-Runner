using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadioSystem : MonoBehaviour
{
    public AudioClip initialHeliCall;
    public AudioClip initialCallReply;

    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnMakeInitialHeliCall()
    {
        Debug.Log("Вызываем вертолет");
        audioSource.clip = initialHeliCall;
        audioSource.Play();
        Invoke(nameof(CallReply), initialHeliCall.length + 1f);
    }

    void CallReply()
    {
        Debug.Log("Вертолет принял вызов");
        audioSource.clip = initialCallReply;
        audioSource.Play();
        BroadcastMessage("OnDispatchHelicopter");
    }
}
