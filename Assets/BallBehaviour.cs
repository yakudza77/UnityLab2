using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehaviour : MonoBehaviour
{
    public float XRotation = 0;
    public float YRotation = 1;
    public float ZRotation = 0;
    public float DegreePerSecond = 180;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Rotate(Vector3.up, 180 * Time.deltaTime); // code that works about the same but without fields  XRotation, YRotation, ZRotation.  Vector3.up works like YRotation = 1
        Vector3 axis = new Vector3(XRotation, YRotation, ZRotation); // Vector3 is type of 3D vectors in Unity
       // transform.Rotate(axis, DegreePerSecond * Time.deltaTime); //  метод Rotate - 3D объект вращается вокруг своей оси
         transform.RotateAround( Vector3.zero, axis, DegreePerSecond * Time.deltaTime); //Vector3.zero == Vector3(0,0,0)  В первом параметре передается точка, относительно которой осуществляется вращение
        Debug.DrawRay(Vector3.zero, axis, Color.yellow, .5f); // Метод рисует луч — вектор, проходящий от одной точки к другой; в параметрах он получает начальную точку, конечную точку и цвет.
       // При вызове метода Debug.DrawRay можно добавить четвертый аргумент со значением времени, в тече-ние которого луч должен оставаться на экране.Добавьте аргумент .5f, чтобы каждый луч оставался наэкране полсекунды (.5f)
    }
}
