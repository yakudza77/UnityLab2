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
       // transform.Rotate(axis, DegreePerSecond * Time.deltaTime); //  ����� Rotate - 3D ������ ��������� ������ ����� ���
         transform.RotateAround( Vector3.zero, axis, DegreePerSecond * Time.deltaTime); //Vector3.zero == Vector3(0,0,0)  � ������ ��������� ���������� �����, ������������ ������� �������������� ��������
        Debug.DrawRay(Vector3.zero, axis, Color.yellow, .5f); // ����� ������ ��� � ������, ���������� �� ����� ����� � ������; � ���������� �� �������� ��������� �����, �������� ����� � ����.
       // ��� ������ ������ Debug.DrawRay ����� �������� ��������� �������� �� ��������� �������, � ����-��� �������� ��� ������ ���������� �� ������.�������� �������� .5f, ����� ������ ��� ��������� �������� ���������� (.5f)
    }
}
