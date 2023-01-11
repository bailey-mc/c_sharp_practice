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
  static Tool[] toolbox = {new Tool("set of teeth", 0, 1), new Tool("pair of rusty scissors", 5, 5), new Tool("old lawnmower", 25, 50), new Tool("nice new lawnmower", 250, 100), new Tool("starving students", 500, 250), new Tool("placeholder", 2000, 0)};

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

    void goShopping() {
      //set variable to receive input//really just so they have to press enter for game to progress... it's fun to have buttons to push
      string input;
      Console.WriteLine("You have $" + bank + " in the bank. That's enough to buy a " + toolbox[numOfTools].name + " for $" + toolbox[numOfTools].cost + ". With a " + toolbox[numOfTools].name + " you will be able to earn $" + toolbox[numOfTools].returns + " a day.");
      //subtract cost of next tool from bank acct
      bank -= toolbox[numOfTools].cost;
      //add to numOfTools ---> all toolbox[numOfTools] info moves up to next index
      numOfTools ++;
      Console.WriteLine("***********************************");
      Console.WriteLine("You have successfully purchased a " + toolbox[numOfTools - 1].name + "! You now have $" + bank + " in the bank.");
      input = Console.ReadLine();
      
      //win condition
      if ((numOfTools == 5) && (bank >= 1000)) {
        Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
        Console.WriteLine("You have a " + toolbox[numOfTools - 1].name + " and $" + bank + " in the bank! You win!");
        Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      }else {
        Console.WriteLine("Ain't no rest for the wicked, huh? back to work for you!");
        Console.WriteLine("*****************************************");
        workToday();
      }
    }

    void wannaGoShopping() {
      //set variable to receive input
      string input;
      Console.WriteLine("you have enough money to buy a " + toolbox[numOfTools].name);
      input = Console.ReadLine();
      Console.WriteLine("Would you like to go shopping? please enter y for yes or n for no");
      input = Console.ReadLine();
      if (input == "y") {
        //if you choose to go shopping, calls function to buy tool
        goShopping();
      } else {
        Console.WriteLine("back to work it is");
        Console.WriteLine("*********************************");
        workToday();
      }
    }

    void makeMoney() {  
      //increment bank acct by return of tool landscaper currently has
      bank += toolbox[numOfTools - 1].returns;
      Console.WriteLine("You made $" + toolbox[numOfTools - 1].returns + " today. You now have $" + bank + " in the bank");
      //win condition
      if ((numOfTools == 5) && (bank >= 1000)) {
        Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
        Console.WriteLine("You have a " + toolbox[numOfTools - 1].name + " and $" + bank + " in the bank! You win!");
        Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      //if you don't have enough money in your bank to buy the next tool, you are asked if you want to work again
      }else if (bank < toolbox[numOfTools].cost) {
        workToday();
      //if you do have enough money to buy next tool, you are asked if you want to go shopping
      } else {
        wannaGoShopping();
      }
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

    //go to work, get into the meat of the game
    landscaper.workToday();
    
  }
}

