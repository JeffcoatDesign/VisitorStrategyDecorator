using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Chapter.Strategy {
    public class FallbackManeuver : MonoBehaviour, IManeuverBehavior
    {
        public void Maneuver (Drone drone)
        {
            StartCoroutine(Fallback(drone));
        }
        IEnumerator Fallback(Drone drone)
        {
            float time = 0;
            float speed = drone.speed;
            Vector3 startPos = drone.transform.position;
            Vector3 endPos = startPos;
            endPos.z = drone.fallbackDistance;

            while (time < speed)
            {
                drone.transform.position = Vector3.Lerp(startPos, endPos, time / speed);
                time += Time.deltaTime;

                yield return null;
            }
        }
    }
}