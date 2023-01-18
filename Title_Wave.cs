using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Title_Wave : MonoBehaviour
{

	Rigidbody2D rigid;

    public int waveScale = 10; //위아래 움직이는 범위값
	float x = 0f;

	private void Awake()
	{
		rigid = GetComponent<Rigidbody2D>();
	}

	private void FixedUpdate()
	{
		
		Vector2 nextVec = new Vector2(rigid.position.x, rigid.position.y+Mathf.Sin(x) * waveScale*Time.fixedDeltaTime);//sin함수를 이용한 상하운동
		rigid.MovePosition(nextVec);
		
		x+=0.1f; //x의 값이 작을 수록 자연스럽게 움직인다.
	}

}
