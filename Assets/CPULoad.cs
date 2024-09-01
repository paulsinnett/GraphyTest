using System.Threading;
using UnityEngine;

public class CPULoad : MonoBehaviour
{
    public int perFrameLoad; // ms

    void Update()
    {
        Thread.Sleep(perFrameLoad);
    }
}
