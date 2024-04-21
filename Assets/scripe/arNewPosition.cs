using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class arNewPosition : MonoBehaviour
{
    public ARRaycastManager raycastManager;
    public GameObject objectToPlace;
    public Camera arCamera;
    private List<ARRaycastHit> hits = new List<ARRaycastHit>();
    // Update is called once per frame
    void Update()
    {
        Ray ray = arCamera.ViewportPointToRay(Input.mousePosition);

        if (Input.GetMouseButton(0))
        {
            if (raycastManager.Raycast(ray, hits, TrackableType.PlaneWithinPolygon))
            {
                Pose hitPose = hits[0].pose;
                Instantiate(objectToPlace, hitPose.position, hitPose.rotation);
            }
        }
    }
}
