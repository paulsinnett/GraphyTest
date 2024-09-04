using System.Threading;
using UnityEngine;

public class Poisson
{
    float lambda;

    public Poisson(float lambda)
    {
        this.lambda = lambda;
    }

    public int GetRandomValue()
    {
        // Algorithm due to Donald Knuth, 1969.
        float p = 1.0f;
        float L = Mathf.Exp( -lambda );
        int k = 0;
        do
        {
            k++;
            p *= Random.value;
        }
        while (p > L);
        return k - 1;
    }
}

public class CPULoad : MonoBehaviour
{
    public float minLoadPerFrame; // ms
    public float meanLoadPerFrame; // ms
    Poisson poisson;

    void Start()
    {
        poisson = new Poisson( meanLoadPerFrame - minLoadPerFrame );
    }

    void Update()
    {
        Thread.Sleep( Mathf.RoundToInt( minLoadPerFrame + poisson.GetRandomValue() ) );
    }
}
