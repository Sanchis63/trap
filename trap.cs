using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class trap : RUN

// RUN - ���������� ������, � ��� �� � �������������� ������������ � ����������
{
    public GameObject igra;
    public RUN rUN;
    public bool ye = false;
    new public void Update()
    {
        

        if (rUN.trap)
        {
            SceneManager.LoadScene("saads", LoadSceneMode.Additive);
            Debug.Log(rUN.trap);
            // ��������� ����� �����
            StartCoroutine(restart());
            if (ye)
            {
                igra.SetActive(false);
                rUN.game.SetActive(false);
                // ��������� ������ �����
            }
            rUN.trap = false;
        }
    }
    IEnumerator restart()
    {
        ye = true;
        SceneManager.LoadScene("igra", LoadSceneMode.Additive);
        yield return new WaitForSeconds(1);
        ye = false;
        


    }
}
