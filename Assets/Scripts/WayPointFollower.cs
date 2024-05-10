using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPointFollower : MonoBehaviour
{
    [SerializeField] public GameObject[] waypoints;
  public int currentwaypoint = 0;

    [SerializeField] private float speed = 2f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
  private void Update()
    {
        if (Vector2.Distance(waypoints[currentwaypoint].transform.position, transform.position) < .5f)
        {
            currentwaypoint++;
            if (currentwaypoint >= waypoints.Length)
            {
                currentwaypoint = 0;
            }
            else if (currentwaypoint >= waypoints.Length) { currentwaypoint--; }

        }
       transform.position = Vector2.MoveTowards(transform.position, waypoints[currentwaypoint].transform.position, Time.deltaTime * speed);
    }
}
