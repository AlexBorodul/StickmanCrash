using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChooseTransport : MonoBehaviour
{
    [SerializeField] private GameObject[] vehiclesDemo;
    public int index = 0;
    //[SerializeField] private GameObject vehicleDemo;
    public static bool isVehicleAvailable { get; private set; } = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(index != 0)
        {
            isVehicleAvailable = false;
        }
        else
        {
            isVehicleAvailable = true;
        }
        ShowVehicleDemo();
    }

    public void OnNextVehicleButtonClick()
    {
        if(index < 3)
            index++;
    }

    public void OnPreviousVehicleButtonClick()
    {
        if (index > 0)
            index--;
    }

    private void ShowVehicleDemo()
    {
        for(var i = 0; i < vehiclesDemo.Length; i++)
        {
            if(i != index)
            {
                vehiclesDemo[i].SetActive(false);
            }
            else
            {
                vehiclesDemo[i].SetActive(true);
            }
        }
    }
}
