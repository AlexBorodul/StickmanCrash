using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    [SerializeField] private WheelJoint2D[] wheels;
    [SerializeField] private float speed;
    [SerializeField] private float torque;
    private JointMotor2D motor = new JointMotor2D();
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        var x = Input.GetAxis("Horizontal");

        if (x > 0)
        {
            motor.motorSpeed -= speed;
            motor.maxMotorTorque = torque;
            wheels[0].motor = motor;
            wheels[1].motor = motor;
        }
        else if (x < 0)
        {
            motor.motorSpeed += speed;
            motor.maxMotorTorque = torque;
            wheels[0].motor = motor;
            wheels[1].motor = motor;
        }
        else
        {
            if (motor.motorSpeed > 0)
            {
                motor.motorSpeed -= speed / 2;
            }
            else
            {
                motor.motorSpeed += speed / 2;
            }
            wheels[0].motor = motor;
            wheels[1].motor = motor;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            motor.motorSpeed = 0;
            wheels[0].motor = motor;
            wheels[1].motor = motor;
        }
    }
}