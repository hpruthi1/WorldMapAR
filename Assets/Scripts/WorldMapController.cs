using GoogleARCore;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldMapController : MonoBehaviour
{
    public GameObject WorldMap;
    public Texture2D WorldMapMarker;
    private List<AugmentedImage> trackedMarkers = null;
    private Dictionary<string, Transform> CreatedObjects;
    public AugmentedImageDatabase database;


    private void Start()
    {
        trackedMarkers = new List<AugmentedImage>();
        CreatedObjects = new Dictionary<string, Transform>();
    }
    // Update is called once per frame
    void Update()
    {
        if(Session.Status != SessionStatus.Tracking)
        {
            Screen.sleepTimeout = SleepTimeout.SystemSetting;
            return;
        }

        Session.GetTrackables<AugmentedImage>(trackedMarkers);
        foreach (AugmentedImage marker in trackedMarkers)
        {
            if (!CreatedObjects.ContainsKey(marker.Name))
            {
                Anchor anchor = marker.CreateAnchor(marker.CenterPose);
                GameObject Map = Instantiate(WorldMap);
                Map.transform.position = marker.CenterPose.position + marker.CenterPose.up * 0.2f;
                Map.transform.localScale *= 0.2f;
                CreatedObjects[marker.Name] = Map.transform;
                WorldMap.transform.parent = anchor.transform;
            }

            else
            {
                CreatedObjects[marker.Name].position = marker.CenterPose.position + marker.CenterPose.up * 0.2f;
            }
        }
    }
}
