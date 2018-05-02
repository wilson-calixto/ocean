using UnityEngine;
using System.Collections;

public class ScoreManagerScript : MonoBehaviour {

    public static int Score { get; set; }
    int previousScore = -1;
    public Sprite[] numberSprites;
    public SpriteRenderer Units, Tens, Hundreds,Thousand, Ten_thousand, Million,Billion,Trillion ;
	// Use this for initialization
	void Start () {
        (Tens.gameObject as GameObject).SetActive(false);
        (Hundreds.gameObject as GameObject).SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {

        if (previousScore != Score) //save perf from non needed calculations
        { 
            if(Score < 10)
            {
                //just draw units
                Units.sprite = numberSprites[Score];
            }
            else if(Score >= 10 && Score < 100)
            {
                (Tens.gameObject as GameObject).SetActive(true);
                Tens.sprite = numberSprites[Score / 10];
                Units.sprite = numberSprites[Score % 10];
            }
            else if(Score >= 100 && Score < 1000)
            {
             (Hundreds.gameObject as GameObject).SetActive(true);
                Hundreds.sprite = numberSprites[Score / 100];
                int rest = Score % 100;
                Tens.sprite = numberSprites[rest / 10];
                Units.sprite = numberSprites[rest % 10];
            }
            else if(Score >= 1000 && Score < 10000)
            {
             (Thousand.gameObject as GameObject).SetActive(true);

                Thousand.sprite = numberSprites[Score / 1000];
                int rest_1=Score % 1000;                         
                Hundreds.sprite = numberSprites[rest_1 / 100];
                int rest = rest_1 % 100;
                Tens.sprite = numberSprites[rest / 10];
                Units.sprite = numberSprites[rest % 10];
            }
           else if(Score >= 10000 && Score < 100000)
            {
             (Ten_thousand.gameObject as GameObject).SetActive(true);

                Ten_thousand.sprite = numberSprites[Score / 10000];
                int rest_2=Score % 10000;
                Thousand.sprite = numberSprites[rest_2 / 1000];
                int rest_1=rest_2 % 1000;                         
                Hundreds.sprite = numberSprites[rest_1 / 100];
                int rest = rest_1 % 100;
                Tens.sprite = numberSprites[rest / 10];
                Units.sprite = numberSprites[rest % 10];
            }
            else if(Score >= 100000 && Score < 1000000)
            {
             (Million.gameObject as GameObject).SetActive(true);
                Million.sprite = numberSprites[Score / 100000];
                int rest_3=Score % 100000;
                Ten_thousand.sprite = numberSprites[rest_3 / 10000];
                int rest_2=rest_3 % 10000;
                Thousand.sprite = numberSprites[rest_2 / 1000];
                int rest_1=rest_2 % 1000;                        
                Hundreds.sprite = numberSprites[rest_1 / 100];
                int rest = rest_1 % 100;
                Tens.sprite = numberSprites[rest / 10];
                Units.sprite = numberSprites[rest % 10];
            }
            else if(Score >= 1000000 && Score < 10000000)
            {
             (Billion.gameObject as GameObject).SetActive(true);
                Billion.sprite = numberSprites[Score / 1000000];
                int rest_4=Score % 1000000;
                Million.sprite = numberSprites[rest_4 / 1000000];
                int rest_3=rest_4 % 100000;
                Ten_thousand.sprite = numberSprites[rest_3 / 10000];
                int rest_2=rest_3 % 10000;
                Thousand.sprite = numberSprites[rest_2 / 1000];
                int rest_1=rest_2 % 1000;                        
                Hundreds.sprite = numberSprites[rest_1 / 100];
                int rest = rest_1 % 100;
                Tens.sprite = numberSprites[rest / 10];
                Units.sprite = numberSprites[rest % 10];
            }
            else if(Score >= 10000000 && Score < 100000000)
            {
             (Trillion.gameObject as GameObject).SetActive(true);
                Trillion.sprite = numberSprites[Score / 10000000];
                int rest_5=Score % 10000000;
                Billion.sprite = numberSprites[rest_5 / 1000000];
                int rest_4=rest_5 % 1000000;
                Million.sprite = numberSprites[rest_4 / 1000000];
                int rest_3=rest_4 % 100000;
                Ten_thousand.sprite = numberSprites[rest_3 / 10000];
                int rest_2=rest_3 % 10000;
                Thousand.sprite = numberSprites[rest_2 / 1000];
                int rest_1=rest_2 % 1000;                         
                Hundreds.sprite = numberSprites[rest_1 / 100];
                int rest = rest_1 % 100;
                Tens.sprite = numberSprites[rest / 10];
                Units.sprite = numberSprites[rest % 10];
            }
        }

	}


    
}
