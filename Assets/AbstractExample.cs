using UnityEngine;

public class AbstractExample : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Bird eagle = new Bird();
        Fish shark = new Fish();
        eagle.Move();
        shark.Move();
    }

    abstract class Animal
    {
        public abstract void Move();
        public void Eat()
        {
            Debug.Log("eat");
        }
    }

    class Bird : Animal
    {
        public override void Move()
        {
            Debug.Log("fly");
        }
    }

    class Fish : Animal
    {
        public override void Move()
        {
            Debug.Log("swim");
        }
    }

    //class Knight : ISword, IShield
    //{
    //    public string Damage { get; set; }
    //    public string DefensivePower { get; set; }

    //    public void Attack()
    //    {

    //    }
    //    public void Defend()
    //    {

    //    }

    //    interface ISword
    //    {
    //        public string Damage { get; set; }
    //        public void Attack();
    //    }

    //    interface IShield
    //    {
    //        public string DefensivePower { get; set; }
    //        public void Defend();
    //    }
    //}
}
