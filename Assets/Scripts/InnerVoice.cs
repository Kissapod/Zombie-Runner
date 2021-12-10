using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InnerVoice : MonoBehaviour
{
    public AudioClip whatHappened;
    public AudioClip goodLandingArea;

    private AudioSource audioSource;
    
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = whatHappened;
        audioSource.Play();
    }
    void OnFindClearArea()
    {
        Debug.Log("Область подходит для вызова вертолета");
        audioSource.clip = goodLandingArea;
        audioSource.Play();
        Invoke(nameof(CallHeli), goodLandingArea.length + 1f);
    }

    void CallHeli()
    {
        SendMessageUpwards("OnMakeInitialHeliCall");
    }
}
