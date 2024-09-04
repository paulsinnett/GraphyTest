using System.Collections;
using System.Threading;
using UnityEngine;

[System.Serializable]
public class SpikeParams
{
    public float period; // s
    public float delay; // s
    public int duration; // ms
}

public class Spike : MonoBehaviour
{
    public SpikeParams [] spikes;

    void OnEnable()
    {
        foreach (SpikeParams spike in spikes)
        {
            StartCoroutine(SpikeGenerator(spike));
        }
    }

    void OnDisable()
    {
        StopAllCoroutines();
    }

    IEnumerator SpikeGenerator(SpikeParams spike)
    {
        yield return new WaitForSeconds(spike.delay);
        while (true)
        {
            Thread.Sleep(spike.duration);
            yield return new WaitForSeconds(spike.period);
        }
    }
}
