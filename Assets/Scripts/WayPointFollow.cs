using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPointFollow : MonoBehaviour
{
    [SerializeField] private GameObject[] wayPoints;
    private int currentWayPointIndex = 0;
    [SerializeField] private float speed = 2f;

    [SerializeField] private float smashSpeed = 10f;
    [SerializeField] private float returnSpeed = 2f;
    private bool isStoneFace;


    private void Update()
    {
        isStoneFace = IsStoneFace();
        if(isStoneFace)
        {
            if (Vector2.Distance(wayPoints[currentWayPointIndex].transform.position, transform.position) < .1f)
            {
                if (currentWayPointIndex == 0)
                {
                    speed = smashSpeed;
                }
                else
                    speed = returnSpeed;
            }
        }
        if (Vector2.Distance(wayPoints[currentWayPointIndex].transform.position, transform.position) < .1f)
        {
            currentWayPointIndex++;
            if (currentWayPointIndex >= wayPoints.Length)
            {
                currentWayPointIndex = 0;
            }
        }

        transform.position = Vector2.MoveTowards(transform.position, wayPoints[currentWayPointIndex].transform.position, Time.deltaTime * speed);
    }
    private bool IsStoneFace()
    {
        if (name == "StoneFace")
        {
            return true;
        }
        else
            return false;
    }
}
