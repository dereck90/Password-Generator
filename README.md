# Password Generator
This is a password generator program written in C# using the .NET framework. 
It generates a random password of a specified length, with a combination of uppercase 
and lowercase letters, numbers, and symbols. The password is then displayed in a textbox 
and can be copied to the clipboard. The program uses a Windows Forms application to 
provide a graphical user interface for the password generation and copying functions.

Usage
To use the password generator, simply run the program and specify the desired length of 
the password using the numeric up-down control. Then click the "Generate" button to 
generate a random password. The generated password will be displayed in the text box.
To copy the password to the clipboard, click the "Copy" button.

If the text box is empty or already contains the word "Copied", clicking the "Copy" button 
will display a message asking the user to generate a new password first.

Implementation Details
The core functionality of the program is implemented in the RandomGenerator method, which
generates a random password based on the specified length and character sets. The method 
uses a combination of uppercase and lowercase letters, numbers, and symbols to generate a 
password that is difficult to guess. The generated password is then shuffled to ensure that 
the characters are randomized.

The program uses the Windows Forms application to provide a graphical user interface for 
the password generation and copying functions. The user interface includes a 
numeric up-down control for specifying the password length, as well as "Generate" and "Copy" 
buttons for generating and copying the password, respectively.

Author
This program was created by Dereck Talavera.