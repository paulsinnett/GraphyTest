using System.Collections;
using System.Threading;
using UnityEngine;

[System.Serializable]
public class SpikeParams
{
    public float period; // s
    public int duration; // ms
}

public class Spike : MonoBehaviour
{
    public SpikeParams [] spikes;

    void Start()
    {
        foreach (SpikeParams spike in spikes)
        {
            StartCoroutine(SpikeGenerator(spike));
        }
    }

    IEnumerator SpikeGenerator(SpikeParams spike)
    {
        while (true)
        {
            yield return new WaitForSeconds(spike.period);
            Thread.Sleep(spike.duration);
        }
    }
}
