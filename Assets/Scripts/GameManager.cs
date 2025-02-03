using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] BallMovement ball;
    [SerializeField] UIManager ui;
    private int playerOneScore = 0;
    private int playerTwoScore = 0;
    private int courtmin = -10;
    private int courtmax = 10;
    void Start()
    {
        if (ball != null)
        {
            ui.UpdateScore(playerOneScore, playerTwoScore);
            ball.Launch(GetRandomBallDirection(), ball.speed);
        }
    }


    void Update()
    {
        if (ball.xPos <= courtmin){
            playerTwoScore++;
            ui.UpdateScore(playerOneScore, playerTwoScore);
            ball.Reset();
            ball.Launch(GetRandomBallDirection(), ball.speed);
        } else if (ball.xPos >= courtmax){
            playerOneScore++;
            ui.UpdateScore(playerOneScore, playerTwoScore);
            ball.Reset();
            ball.Launch(GetRandomBallDirection(), ball.speed);
        }        
    }

    // Method to create a random starting Vector direction of the ball.
    public Vector3 GetRandomBallDirection()
    {
        float x = 1;
        float y = 1;

        // find a random number to make x or y, 1 or -1
        int firstRandNum = Random.Range(0,2);
        int secondRandNum = Random.Range(0,2);
        
        // logic to set correct values of x and y
        if (firstRandNum == 0){
            x = 1;
        } else if (firstRandNum == 1){
            x = -1;
        }
        if (secondRandNum == 0){
            y = 1;
        } else if (secondRandNum == 1){
            y = -1;
        }


        Vector3 randomDirection = new Vector3(x, y, 0);
        return randomDirection;
    }
}
