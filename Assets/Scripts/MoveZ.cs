using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveZ : MonoBehaviour {
	Vector3 nowPst;
	public float delta;  // 이동가능한 x의 최대값
	public float speed;  // 이동 속도

	// 회전
	public bool isRotating = false;
	public Vector3 rotationAngle;
	public float rotationSpeed;


	// Use this for initialization
	void Start()
	{
		nowPst = transform.position; // 현재 위치
	}
	void Update()
	{
		Vector3 vt = nowPst;
		vt.z += delta * Mathf.Sin(Time.time * speed);
		transform.position = vt;
		if (isRotating)
		{
			transform.Rotate(rotationAngle * rotationSpeed * Time.deltaTime);
		}
	}
}
