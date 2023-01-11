using System;

class Program {

  //Tool class
  class Tool {
    public string name;
    public int cost;
    public int returns;

    //constructor
    public Tool( string name, int cost, int returns){
      this.name = name;
      this.cost = cost;
      this.returns = returns;
    }

  }

  //toolbox is created
  static Tool[] toolbox = {new Tool("teeth", 0, 1), new Tool("scissors", 5, 5), new Tool("old lawnmower", 25, 50), new Tool("nice new lawnmower", 250, 100), new Tool("starving students", 500, 250)};

  //Landscaper class
    class Landscaper {
    public string name;
    public int bank;
    // public static Tool[] tools = toolbox;
    public int numOfTools;

    //constructor
    public Landscaper( string name, int bank, int numOfTools){
      this.name = name;
      this.bank = bank;
      this.numOfTools = numOfTools;
     
    }

    public void makeMoney() {
      bank += toolbox[numOfTools - 1].returns;
      Console.WriteLine("You made $" + toolbox[numOfTools - 1].returns + " today. You now have $" + bank + " in the bank");
    }

    public void workToday() {
    //set variable for response
    string work;
    Console.WriteLine("Would you like to work today? press y for yes or n for no");
    work = Console.ReadLine();
    if (work == "y") {
      makeMoney();
    } else {
      Console.WriteLine("you chose not to work today");
    }
  }

  }



  //HERE'S WHERE THE ACTION HAPPENS
  public static void Main (string[] args) {
    //set variable for input
    string input;
    Console.WriteLine("What's your name?");
    //receive input
    input = Console.ReadLine();
    //print message
    Console.WriteLine("Hello " + input);

    //landscaper 'instantiated' as player. no money
    Landscaper landscaper = new Landscaper(input, 0, 1);

    // Console.WriteLine(landscaper.name + " name, money : " + landscaper.bank + "tools? " + toolbox[landscaper.numOfTools - 1].name);

    landscaper.workToday();
    

    // foreach (Tool tool in toolbox){
    //   Console.WriteLine("name: " + tool.name + ", cost: " + tool.cost + ", return: " + tool.returns);
    // }
  }
}

//CODE GRAVEYARD
// using System;

// class Program {
  
//   class Creature{
    
//     protected string name;
//     protected int age;
//     protected int legs;
//     protected bool goodBoy;

//     //constructor function --runs this function when the object is created
//     public Creature(string nm, int ag, int leg, bool good){
//       name = nm;
//       age = ag;
//       legs = leg;
//       goodBoy = good;
//     }

//     // this second version of the constructor is so that if someone passes in nothing, nothing is created
//     public Creature() {
      
//     }
//     //destructor function --runs this function when the object is destroyed
//     ~Creature(){
//       Console.WriteLine(this.name + " has died at the age of " + this.age);
//     }

//     public void aging (){
//         age++;
//         Console.WriteLine(this.name + " is now of age " + this.age);
//     }
//   }
//     //new Dog class that will inherit properties of Creature class
//     class Dog : Creature{
//         //Dog gets its own constructor
//         //Creature constructor is run first, then dog constructor is run after
//         //this is where empty constructor on line26 comes in... so program can call creature constructor w/ no parameters passed in w/o breaking. then it can call dog constructor under/into that
//         public Dog (string nm, int ag){
//             name = nm;
//             age = ag;
//             legs = 4;
//             goodBoy = true;
//         }

//         //public functions so we can call on them outside of the class definition
//         public void bark(){
//             Console.WriteLine("Bark");
//         }

//         public void info(){
//             Console.WriteLine("name: " + this.name + ", age: " + this.age + ", legs: " + this.legs + ", good boy? " + this.goodBoy);
//         }
//     }
    
//     static int addFive (int x) {
//         Console.WriteLine("testingggg");
//         return x + 5;
//     }
  
//   public static void Main (string[] args) {

//     Creature sukiCat = new Creature("Suki", 3, 4, true);
//     sukiCat.aging();
//     sukiCat.aging();

//     Dog tucker = new Dog("Tucker", 8);
//     tucker.aging();
//     tucker.bark();
//     tucker.info();
//     tucker.bark();

//     Console.WriteLine(addFive(6));

    
//   }
// }
