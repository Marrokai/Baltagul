using UnityEngine;

// Makes objects float up & down while gently spinning.
public class Levitation : MonoBehaviour
{
    Random baka;
    public float amplitude = 1f;
    public float frequency = 1f;
    public float degreesX = 15f;
    public float degreesY = 15f;
    public float degreesZ = 15f;
    public float RotAmplitude = 2f;
    public Vector3 possInit;
    public Vector3 possTemp;
    public float RotX;
    public float RotY;
    public float RotZ;
    public float accX = 0;
    public float accY = 0;
    public float accZ = 0;
    // Use this for initialization
    void Start()
    {
        possInit = transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        RotX = degreesX * RotAmplitude * Time.deltaTime * accX;
        RotY = degreesX * RotAmplitude * Time.deltaTime * accY;
        RotZ = degreesX * RotAmplitude * Time.deltaTime * accZ;
        transform.Rotate(new Vector3(RotX, RotY, RotZ));
        possTemp = possInit;
        possTemp.y += Mathf.Sin(Time.fixedTime * frequency) * amplitude;
        transform.position = possTemp;
        if( accX >= 1 || accX <= -1)
        {
            accX = Random.Range(-1.0f,1.0f);
        }
        if (accY >= 1 || accY <= -1)
        {
            accY = Random.Range(-1.0f, 1.0f);
        }
        if (accZ >= 1 || accZ <= -1)
        {
            accZ = Random.Range(-1.0f, 1.0f);
        }
        if (accX >= 0) accX += 0.005f;
        if (accY >= 0) accY += 0.005f;
        if (accZ >= 0) accZ += 0.005f;
        if (accX <= 0) accX -= 0.005f;
        if (accY <= 0) accY -= 0.005f;
        if (accZ <= 0) accZ -= 0.005f;
    }
}