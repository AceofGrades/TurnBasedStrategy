using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{
	public static event EventHandler<InfoEventArgs<Point>> moveEvent;
	public static event EventHandler<InfoEventArgs<int>> fireEvent;

	Repeater _hor = new Repeater("Horizontal");
	Repeater _ver = new Repeater("Vertical");
	string[] _buttons = new string[] { "Fire1", "Fire2", "Fire3" };

	void Update()
	{
		int x = _hor.Update();
		int y = _ver.Update();
		if (x != 0 || y != 0)
		{
			if (moveEvent != null)
				moveEvent(this, new InfoEventArgs<Point>(new Point(x, y)));
		}

		for (int i = 0; i < 3; ++i)
		{
			if (Input.GetButtonUp(_buttons[i]))
			{
				if (fireEvent != null)
					fireEvent(this, new InfoEventArgs<int>(i));
			}
		}
	}
}
