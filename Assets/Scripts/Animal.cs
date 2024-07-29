using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public enum spicies{Cat,Dog,Bird};
public class Animal : MonoBehaviour
{
    //ABSTRACTION...

    Color color;
    int _age;
    public int age
    {
        get { return _age; }
        set
        {
            if (age > 0 && age < 13)
            {
                _age = value;
            }
            else
            {
                print("VALOR INCORRECTO");
            }
        }
    }
    string sound;
    string food;
    [SerializeField] Color animalColor;
    [SerializeField] TMP_Text spiciesShower;
    [SerializeField] Button animalData;



    public void Eat(string food)
    {
        print($"IT'S EATING {food.ToUpper()}");
    }

    public void MakeSound(string sound)
    {
        print($"{sound.ToUpper()}");
    }

    public void Breath()
    {
        print("Breathing,Breathing,Breathing,...");
    }

    public void Movement()
    {
        print("Moving,Moving,Moving...");
    }
}
