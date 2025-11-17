using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

[ExecuteAlways]
public class LensFlareController : MonoBehaviour
{
    public Light sun;
    
    public Transform flareParent;

    private void Update()
    {
        flareParent.rotation = sun.transform.rotation;
    }
}
