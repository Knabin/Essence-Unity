using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestAnimal : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Cat nate = new Cat();
        nate.name = "Nate";
        nate.weight = 1.5f;
        nate.year = 3;

        Dog2 jack = new Dog2();
        jack.name = "Jack";
        jack.weight = 5f;
        jack.year = 2;


        //////

        nate.Stealth();
        nate.Print();

        jack.Hunt();
        jack.Print();

        //nate.GetSpeed();

        // Base로써 Dog과 Cat을 가져올 수 있다.
        // 단, 파생 클래스의 고유 기능은 사용할 수 없다.
        Animal someAnimal = jack;
        someAnimal.Print();
        //someAnimal.Hunt();    // Error!

        Animal[] animals = new Animal[2];
        
        animals[0] = nate;
        animals[1] = jack;

        for (int i = 0; i < animals.Length; ++i)
        {
            animals[i].Print();
            //animals[i].Hunt();    // Error!
        }
    }
}
