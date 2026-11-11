using Unity.VisualScripting;
using UnityEngine;

public class ConstructorExample : MonoBehaviour
{
    void Start()
    {
        Adult maria = new Adult("Alice", 26, 165.5f);
        maria.Age = 10;
        maria.SetBaseAge(2);
        Debug.Log(maria.Age);
        Debug.Log(maria.GetBaseAge());

        Human Alexis = new Human("alexis", 23, 125);
        Adult adult_alexis = Alexis as Adult;

        if (adult_alexis == null)
        {
            Debug.Log("형변환 실패");
        }
        else
        {
            Debug.Log("형변환 성공");
        }

        //Human jason = maria;
        //Debug.Log(jason.GetAge());

        //Human Bob = new Human("bob", 26, 165.5f);
        //Adult tmpA = (Adult)Bob;
    }
}


class Human
{
    public string name;
    public int age;
    public float height;
    protected string address;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public int Age
    {
        get { return age; }
        set { age = value; }
    }
    public float Height
    {
        get { return height; }
        set { height = value; }
    }
    public int GetAge()
    {
        return age;
    }
    public void SetAge(int _age)
    {
        age = _age;
    }
    public Human()
    {

    }
    public Human(string name, int age, float height)
    {
        this.name = name;
        this.age = age;
        this.height = height;
    }
    public void Eat()
    {
        Debug.Log("eat");
    }
    public virtual void Walk()
    {
        Debug.Log("walk");
    }
    public void Sleep()
    {
        Debug.Log("sleep");
    }
}

class Adult : Human
{
    public Adult(string _name, int _age, float _height) : base(_name, _age, _height)
    {
        Age = _age;
    }

    public void PrintAddress()
    {
        Debug.Log(address);
    }

    public new int Age;
    public void SetBaseAge(int age)
    {
        base.age = age;
    }

    public int GetBaseAge()
    {
        return base.age;
    }
}