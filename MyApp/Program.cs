// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Console.WriteLine("The current time is " + DateTime.Now);

using System;

class Program {
  
  class Creature{
    
    protected string name;
    protected int age;
    protected int legs;
    protected bool goodBoy;

    //constructor function --runs this function when the object is created
    public Creature(string nm, int ag, int leg, bool good){
      name = nm;
      age = ag;
      legs = leg;
      goodBoy = good;
    }

    // this second version of the constructor is so that if someone passes in nothing, nothing is created
    public Creature() {
      
    }
    //destructor function --runs this function when the object is destroyed
    ~Creature(){
      Console.WriteLine(this.name + " has died at the age of " + this.age);
    }

    public void aging (){
        age++;
        Console.WriteLine(this.name + " is now of age " + this.age);
    }
  }
    //new Dog class that will inherit properties of Creature class
    class Dog : Creature{
        //Dog gets its own constructor
        //Creature constructor is run first, then dog constructor is run after
        //this is where empty constructor on line26 comes in... so program can call creature constructor w/ no parameters passed in w/o breaking. then it can call dog constructor under/into that
        public Dog (string nm, int ag){
            name = nm;
            age = ag;
            legs = 4;
            goodBoy = true;
        }

        //public functions so we can call on them outside of the class definition
        public void bark(){
            Console.WriteLine("Bark");
        }

        public void info(){
            Console.WriteLine("name: " + this.name + ", age: " + this.age + ", legs: " + this.legs + ", good boy? " + this.goodBoy);
        }
    }
    
    static int addFive (int x) {
        Console.WriteLine("testingggg");
        return x + 5;
    }
  
  public static void Main (string[] args) {

    Creature sukiCat = new Creature("Suki", 3, 4, true);
    sukiCat.aging();
    sukiCat.aging();

    Dog tucker = new Dog("Tucker", 8);
    tucker.aging();
    tucker.bark();
    tucker.info();
    tucker.bark();

    Console.WriteLine(addFive(6));

    
  }
}

