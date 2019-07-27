
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{
    public enum SpawnState { SPAWNING, WAITING, COUNTING }

    [System.Serializable]
    public class Wave
    {
        public Transform enemy;
    }
    public Wave[] waves;
    private int nextWave = 0;

    public float timeBetween = 5;
    public float waveCountDown;

    private SpawnState state = SpawnState.COUNTING;

    void Start()
    {
        waveCountDown = timeBetween;
    }

    void Update()
    {
        if (waveCountDown <= 0)
        {
            if (state != SpawnState.SPAWNING)
            {
                //spawns
                StartCoroutine(SpawnWave(waves[nextWave]));
            }
        }
        else
        {
            waveCountDown -= Time.deltaTime;
        }
    }
    IEnumerator SpawnWave(Wave wave)
    {
        state = SpawnState.SPAWNING;
        //spawn

        state = SpawnState.WAITING;

        yield break;
    }
}
