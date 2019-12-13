abstract class First // Abstract class has to be implement using inheritence 
{
    public void Foodmenu() // The abstract class contain regular method
    {

        string Maincourse = "Steakhouse";
        System.Console.WriteLine("The main course is" + Maincourse);

    }
    public abstract void desertmenu(); // This is abstract method.

}
 class  Second : First
{
        public override void desertmenu()
        {
            System.Console.WriteLine("The desert menu has ice cream");

        }

         static void Main()

        {
            Second obja = new Second(); // The object of inherited class, Abstract class object cannot be created. 
            obja.desertmenu();
            obja.Foodmenu();

        // First obja = new First();
        //obja.Foodmenu();


    }

}