using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class halikadic1_pokreniVideo : MonoBehaviour
{
    Ray ray;
    RaycastHit hit;

    public GameObject Play;
    public GameObject Plane;
    //public UnityEngine.Video.VideoPlayer videoPlayer;
    public GameObject Stop;

    void Start()
    {
        Stop.SetActive(false);
        Plane.SetActive(false);
        //videoPlayer = Plane.GetComponent<UnityEngine.Video.VideoPlayer>();
    }

    void Update()
    {
        if ((Input.touchCount > 0) && (Input.GetTouch(0).phase == TouchPhase.Began))
        {
            ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject.name == "halikadic1_Play")
                {
                    //var videoPlayer = Plane.AddComponent<UnityEngine.Video.VideoPlayer>();
                    /* videoPlayer.playOnAwake = false;  
                    videoPlayer.renderMode = UnityEngine.Video.VideoRenderMode.CameraNearPlane;
                    videoPlayer.targetCameraAlpha = 0.5F;
                    videoPlayer.frame = 100;
                    videoPlayer.isLooping = true;
                    videoPlayer.loopPointReached += EndReached;
                    videoPlayer.Play(); */

                    Plane.SetActive(true);
                    Play.SetActive(false);
                    Stop.SetActive(true);
                }
                if (hit.collider.gameObject.name == "halikadic1_Stop")
                {
                    Plane.SetActive(false);
                    Play.SetActive(true);
                    Stop.SetActive(false);
                }
            }
        }
    }

    /* void EndReached(UnityEngine.Video.VideoPlayer vp) {
        vp.playbackSpeed = vp.playbackSpeed / 10.0F;
    } */
}
