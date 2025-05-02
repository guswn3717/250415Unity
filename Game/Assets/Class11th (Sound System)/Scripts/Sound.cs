using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    [SerializeField] int count;
    [SerializeField] float time = 5;
    [SerializeField] AudioClip audioClip;
    [SerializeField] AudioManager audioManager;

    private void Start()
    {
        count = Random.Range(1, 6);
    }

    private void Update()
    {
        time -= Time.deltaTime;
        if (time <= 0)
        {
            time = 5;
        }
    }
}