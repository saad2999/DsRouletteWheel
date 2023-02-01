using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wheel : MonoBehaviour
{
    SpinWheel obj;
    int money = 0;
    public GameObject wheelTOspin;
    // Start is called before the first frame update
    void Start()
    {
        obj = new SpinWheel(8);
        //obj.setMaxTime(10);
        //obj.setMinTime(2);
        obj.setVelocity(10);
        obj.AddCallback((index) => {
            switch (index)
            {
                case 1:
                    money += 100;
                    Debug.Log(money);

                    break;
                case 2:
                    money += 500;
                    Debug.Log(money);

                    break;
                case 3:
                    money += 100;
                    Debug.Log(money);

                    break;
                case 4:
                    money += 100;
                    Debug.Log(money);

                    break;
                case 5:
                    money += 200;
                    
                    Debug.Log(money);
                    break;
                case 6:
                    money += 100;
                    Debug.Log(money);

                    break;
                case 7:
                    money += 200;
                    Debug.Log(money);
                   break;
                case 8:
                    money += 300;
                    Debug.Log(money);
                    break;
            }
            
        });
        obj.setWheel(wheelTOspin);
        
        StartCoroutine( obj.StartNewRun());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
