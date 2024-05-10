 /*1. The first sentence of Alice’s Adventures in Wonderland is below. 
    Store this sentence in a string, and then prompt the user for a term to 
    search for within this string. Print whether or not the search term was 
    found. Make the search case-insensitive, so that searching for “alice”, 
    for example, prints true*/

        string alice = @"Alice was beginning to get very tired of sitting by her 
        sister on the bank, and of having nothing to do: once or twice she had peeped 
        into the book her sister was reading, but it had no pictures or conversations 
        in it, 'and what is the use of a book,' thought Alice 'without pictures or
        conversation?'";
        Console.WriteLine(alice);
            
        //Prompt User for Term
        Console.WriteLine("What term would you like to look for in the sentence above? ");
        string searchTerm = Console.ReadLine();

        //Case Insensitive and Verify in Sentence
        string compSearchTerm = searchTerm.ToLower();           //this is taking the term the user selected and making it lowercase
        string compAlice = alice.ToLower();                     //this is making the whole quote variable 'alice' to lowercase

        if (compAlice.IndexOf(compSearchTerm, 0) != -1)
        {
            Console.WriteLine("The term " + "'" + compSearchTerm + "'" + " was found in the sentence.");
            
            //Find Index and Length
            int index = alice.IndexOf(searchTerm);
            int length = searchTerm.Length;
            Console.WriteLine("The term " + "'" + compSearchTerm + "'" + " was found at index " + index + " with a length of " + length + ".");
        }
        else 
        {
            Console.WriteLine("The term " + "'" + compSearchTerm + "'" + " was not found in the sentence.");

        }

/*2. Extend the previous exercise. Assume the user enters a word that is 
    in the sentence. Print out its index within the string and its length. 
    Next, remove the word from the string and print the sentence again to 
    confirm your code. Remember that strings are immutable, so you will 
    need to reassign the old sentence variable or create a new one to store 
    the updated phrase.*/

        