# Mastermind
This project was a great learning exercise. It was intimidating at first, and took me some time to break into smaller pieces. First, I needed to randomly
generate a number. Then I needed to store that number, read the user's input, and then store the user's input. I also needed to loop these actions, which I did
using a for loop and while loop. From there I needed to figure out the main logic of the exercise, which was checking the user's number against the randomly
generated number. The remaining details were worked out from there. 

On Stack Overflow I came across the .Random() function to generate a random number, and later found out that that some developers will argue if
this built-in function truly provides randomization. The Random() function did appear to slightly favor numbers, or not quickly enough switch up the numbers similarly
to lightly shuffling a deck. I am curious about other ways to approach this, and I would imagine I could many more clock hours researching it.

The biggest challenge for me in this exercise was determining the logic to check the user's input against the randomly generated number. I set up the randomNumber 
and userInput each as strings, and decided to loop through each string. The program is functional, however I could not get it to account for duplicates. 
I was able to successfully compare the values of both strings, but I ran into issues when comparing the locations, such as on line 81 of my code. 

This is partly because the index location of each string is 0. I needed to start the loops at 0, otherwise it would skip over the first element and wouldn't loop through 
the entire string. I tried reassigning the index to 0 when there was a match found. I think if I approached this with the randomNumber and userInput variables as arrays
or lists, I would have more flexibility. Since it's been hours of troubleshooting, at this point in a work environment I would go to mentor or team member for some guidance. 


# Functionality
If the randomly generated number does not have any duplicates and the user guesses the number correctly, the console will return a "++++". If the randomly generated
number has duplicates next to each other such as in the number 6556, and the user guesses the number correctly, the console will return a "++". If the randomly generated number
has duplicates which are spread out such as in the number 6465, and the user guesses the number correctly, the console will return a "+++-". 

That and other edge cases are not handled at the time of this initial commit. 

# Overall
I want to make sure the work I'm turning in is an honest representation of my understanding, and I realize I'm not going to completely get everything right 
the first time. This was a great exercise, and once I got over the intimidation aspect of it I really enjoyed building it. 
