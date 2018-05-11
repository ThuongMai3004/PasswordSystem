# PasswordSystem  
New way to generate password using meaningful keyword.  

### Programmers:
* Thuong Mai
* Syed Arsal Abbas
* Muhammad Junaid Farooqui

![Main Menu](https://github.com/ThuongMai3004/PasswordSystem/blob/master/images/image6.png?raw=true)  
>The first menu when running the software  


![Register Form](https://github.com/ThuongMai3004/PasswordSystem/blob/master/images/image1.png?raw=true)  
>Generate 3 password forms  


![Register Help Form](https://github.com/ThuongMai3004/PasswordSystem/blob/master/images/image28.png?raw=true)  
>Generate password


![Hint Form](https://github.com/ThuongMai3004/PasswordSystem/blob/master/images/image36.png?raw=true)  
> Display hint for user to memorize the password easier


![Login Many Form](https://github.com/ThuongMai3004/PasswordSystem/blob/master/images/image22.png?raw=true)
>Login form 


![Login Form](https://github.com/ThuongMai3004/PasswordSystem/blob/master/images/image34.png?raw=true) 
>User input the password to login



## The Scheme  
Nowadays, we can see that when a software generates a password, it usually has no meaning, too random and too hard to memorize. So, our team came up with a solution that can basically encrypt a meaningful word into a password and allows a user to memorize it rather easily.  
We have a list of meaningful words in our database that have the length from 5 to 8 characters, 1800 words to be exact. We created a code to randomly select a word from the list, then convert the appropriate characters of the word to a special character by using our following method:  
‘a’ will be converted to --> @  
‘b’ --> 8  
‘i’ --> !  
‘o’ --> 0 (number 0)  
‘s’ --> $  
‘t’ --> +  
To strengthen the converted password, we add 2-digit number of the current day. For example, if the word “tower” is selected as a password for the current user, it will be converted to “+0wer03” with 03 being the date this scheme was created, that is April the 3rd.
  
We believe that this scheme has a good usability and the password the will generated through this scheme will be easy for user to recall. Our password uses 20 normal characters in alphabet (omit the 6 characters that convert to the special characters), with 10 digits number, and 4 special characters, the total of characters is 34. We have at least 7 characters in the password (5 characters from the word lists plus 2 numbers), so the password space would roughly equal to:  

> 34 characters, length 7 => Log(base 2) 34^7 = 36 bits
                              		
Since the word selected for the password would be meaningful, The password would be easy to memorize, recall and reuse. Plus, with the length and the combination of the characters, the password provides a good security compared to other normal passwords. Based on Kaspersky website, the password “+0wer03” takes 2 hours to brute force with an average home computer. The word, selected for the password, will be then removed from the word list and only the user who selected that password will know what the word is.

