using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GAD176.WeeklyActivities.WeekTwo
{
    public class SpaceDebris : Obstacle
    {
        [SerializeField] private float oscillateSpeed = 2;
        private void Update()
        {
            MoveSpaceDebris();
        }

        // Call Move and Oscillate separately in a SpaceDebris-specific method
        public void MoveSpaceDebris()
        {
            // call the Move function from out base class.
            Move();
            Oscillate();
            // call our Oscillate function from our script.
        }

        // Unique behavior for space debris
        private void Oscillate()
        {
            // here's let's Rotate our object
            // to do this we need to multiply our Vector3.right
            // by sin of the current time (Time.time) multiplied by 
            // our oscillate speed
            Vector3 oscillateVector = Vector3.right*Mathf.Sin(oscillateSpeed*Time.time);

            transform.Translate(oscillateVector * Time.deltaTime);
        }
    }
}