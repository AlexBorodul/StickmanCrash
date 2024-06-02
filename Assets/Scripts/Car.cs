using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Car : MonoBehaviour
{
    [SerializeField] private WheelJoint2D[] wheels;
    [SerializeField] private float speed;
    [SerializeField] private float torque;
    [SerializeField] private WheelTrigger wheelTrigger1;
    [SerializeField] private WheelTrigger wheelTrigger2;
    private JointMotor2D motor = new JointMotor2D();
    private int moveDir = 0;

    //Мой код здесь //
    [Header("Health")]
    [SerializeField] private float Health;
    [SerializeField] private Image HealthBar;
    public static Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            moveDir--;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            moveDir++;
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            moveDir++;
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            moveDir--;
        }
        if(!Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D))
        {
            moveDir = 0;
        }

        

        if (Input.GetKeyDown(KeyCode.Space))
        {
            motor.motorSpeed = 0;
            wheels[0].motor = motor;
            wheels[1].motor = motor;
        }

/*        // мой тестовый код - УДАЛИТЬ ПОТОМ //
        if (Input.GetKeyDown(KeyCode.K))
        {
            GetDamage();
        }*/
    }



    private void FixedUpdate()
    {
        if (wheelTrigger1.IsOnGround() || wheelTrigger2.IsOnGround())
        {
            if (moveDir > 0)
            {
                if (motor.motorSpeed > 0)
                {
                    motor.motorSpeed = 0;
                }
                else
                {
                    motor.motorSpeed -= speed;
                }
                motor.maxMotorTorque = torque;
                wheels[0].motor = motor;
                wheels[1].motor = motor;
            }
            else if (moveDir < 0)
            {
                if (motor.motorSpeed < 0)
                {
                    motor.motorSpeed = 0;
                }
                else
                {
                    motor.motorSpeed += speed;
                }
                motor.maxMotorTorque = torque;
                wheels[0].motor = motor;
                wheels[1].motor = motor;
            }
            else
            {
                if (motor.motorSpeed > 0)
                {
                    motor.motorSpeed -= speed * 2;
                }
                else
                {
                    motor.motorSpeed += speed * 2;
                }
                wheels[0].motor = motor;
                wheels[1].motor = motor;
            }
        }
        else
        {
            motor.motorSpeed = 0;
            wheels[0].motor = motor;
            wheels[1].motor = motor;

            /*if (moveDir > 0)
            {
                transform.localEulerAngles += new Vector3(0, 0, -1);
            }
            else if (moveDir < 0)
            {
                transform.localEulerAngles += new Vector3(0, 0, 1);
            }
            else
            {

            }*/

        }
    }

    // Мой код здесь //
    public void GetDamage(float damage)
    {
        Health -= damage;
        HealthBar.fillAmount = Health * 0.01f;

        if (Health <= 0)
        {
            print("Destroyed");
            Destroy(gameObject);
        }
    }
}