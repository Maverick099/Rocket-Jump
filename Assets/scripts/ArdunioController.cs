using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;





public class ArdunioController : MonoBehaviour
{
    public static ArdunioController Input;
    private string COM5;
    public string Data;
    private SerialPort Stream;
    // Start is called before the first frame update
    void Start()
    {
        Stream = new SerialPort(COM5, 9600);
    }

    // Update is called once per frame
    void Update()
    {
        Data = Stream.ReadLine();
    }
}
