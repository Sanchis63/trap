using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class trap : RUN

// RUN - ���������� ������, � ��� �� � �������������� ������������ � ����������
{
    public bool ye = false;
    new public void Update()
    {
        RUN rUN = new RUN();

        if (rUN.trap)
        {
            SceneManager.LoadScene("igra", LoadSceneMode.Additive);
            Debug.Log(rUN.trap);
            // ��������� ����� �����
            StartCoroutine(restart());
            if (ye)
            {
                rUN.game.SetActive(false);
                // ��������� ������ �����
            }
        }
    }
    IEnumerator restart()
    {
        SceneManager.LoadScene("igra", LoadSceneMode.Additive);
        yield return new WaitForSeconds(1);
        ye = true;

    }
}
