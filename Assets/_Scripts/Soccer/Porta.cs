using System.Collections;
using UnityEngine;

public class Porta : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            Debug.Log("Goal!");
            SoccerManager.Instance?.ScorePoints(1);

            StartCoroutine(BallResetWait());
        }
    }

    IEnumerator BallResetWait()
    {
        yield return new WaitForSeconds(1f);

        SoccerManager.Instance?.ResetBall();
    }

}
