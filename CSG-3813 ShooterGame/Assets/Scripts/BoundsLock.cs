using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundsLock : MonoBehaviour
{
    public Rect levelBounds; // x and y, w and h, of bounding rect


    private void LateUpdate()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, levelBounds.xMin, levelBounds.xMax),
                                         transform.position.y,
                                         Mathf.Clamp(transform.position.z, levelBounds.yMin, levelBounds.yMax));
    }

    private void OnDrawGizmosSelected()
    {
        const int cubeDepth = 1;
        Vector3 boundsCenter = new Vector3(levelBounds.xMin + levelBounds.width*0.5f, 0, levelBounds.yMin + levelBounds.height * 0.5f);
        Vector3 boundsSize = new Vector3(levelBounds.width, cubeDepth, levelBounds.height);
        Gizmos.DrawWireCube(boundsCenter, boundsSize);
    }
}
