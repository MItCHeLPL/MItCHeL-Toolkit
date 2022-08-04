using UnityEngine;
using UnityEngine.UI;

public class Scroll : MonoBehaviour
{
	private Scrollbar _scrollbar;
	[SerializeField] private float _amount = 0.2f;

    void Start()
    {
		_scrollbar = GetComponent<Scrollbar>();
	}

    void Update()
    {
		if (Input.GetAxis("Mouse ScrollWheel") > 0f)
		{
			_scrollbar.value += _amount;
		}
		else if (Input.GetAxis("Mouse ScrollWheel") < 0f)
		{
			_scrollbar.value -= _amount;
		}
	}
}
