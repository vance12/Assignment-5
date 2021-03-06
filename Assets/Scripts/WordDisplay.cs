using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WordDisplay : MonoBehaviour {

	public Text text;
	public float fallSpeed = 1f;

	private void Update()
	{
		transform.Translate(0f, -fallSpeed * Time.deltaTime, 0f);

		if (transform.position.y < -5)
		{
			if (Data.Instance.lives > 0)
			{
				Data.Instance.lives--;
				Destroy(gameObject);
			}
			else
			{
				SceneManager.LoadScene("End");
			}
		}
	}

	public void SetWord (string word)
	{
		text.text = word;
	}

	public void RemoveLetter ()
	{
		text.text = text.text.Remove(0, 1);
		text.color = Color.red;
	}

	public void RemoveWord ()
	{
		Data.Instance.score++;
		Destroy(gameObject);
	}

}
