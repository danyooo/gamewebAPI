// Get user's inputs
class user
{

    //has a 'typed' variable(for when the user types "run" would check if it was accurately typed)
    public string cmd = ""; // to be entered by the user. Set to "" so the While Loops can detect whether it is empty or not
                            // Create a keyInput variable to return the pressed key to
    public char keyInput;
    //has a method that reads inputs
    public void readInput()
    {
        //  ConsoleKeyInfo is the only variable that can take an input from the 'Console.ReadKey' method
        ConsoleKeyInfo keyPress = Console.ReadKey();
        // Set the keyInput value to the key that was pressed
        keyInput = keyPress.KeyChar;
    }


    // Method to read user's command input (looking for "run" in specific. Later on could be developed into search by titles/genres)
    public void submitCMD(List<char> listName)
    {
        // do not accept the enter key into the players name
        if (this.keyInput != (char)(13))
        {

            listName.Add(this.keyInput);
        }
        // If enter is pressed..
        else if (this.keyInput == (char)(13))
        {

            //  Convert & Merge each character typed into one string to form a                       name
            this.cmd = string.Concat(listName);

            //
        }
    }
}