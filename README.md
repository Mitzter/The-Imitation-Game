_During World War 2, you are a mathematician who has joined the cryptography team to decipher the enemy's enigma code. Your job is to create a program to crack the codes. 
_
On the first line of the input, you will receive the encrypted message. After that, until the "Decode" command is given, you will be receiving strings with instructions for different operations that need to be performed upon the concealed message to interpret it and reveal its true content. There are several types of instructions, split by '|'

**"Move {number of letters}":**

Moves the first n letters to the back of the string

**"Insert {index} {value}":**

Inserts the given value before the given index in the string

**"ChangeAll {substring} {replacement}":
**
Changes all occurrences of the given substring with the replacement text

**Input / Constraints**

On the first line, you will receive a string with a message.

On the following lines, you will be receiving commands, split by '|' .

**Output**

After the "Decode" command is received, print this message:

"The decrypted message is: {message}"

Examples

**Input	**
zzHe

ChangeAll|z|l

Insert|2|o

Move|3


**Output**
Decode	The decrypted message is: Hello
Comments
ChangeAll|z|l
zzHe → llHe (We replace all occurrences of 'z' with 'l')
Insert|2|o
llHe → lloHe (We add an 'o' before the character on index 2)
Move|3
lloHe → Hello (We take the first three characters and move them to the end of the string)
Finally, after receiving the "Decode" command, we print the resulting message.
Input	Output
owyouh
Move|2
Move|3
Insert|3|are
Insert|9|?
Decode	The decrypted message is: howareyou?
JS Examples
Input	Output
[
  'zzHe',
  'ChangeAll|z|l',
  'Insert|2|o',
  'Move|3',
  'Decode',
]	The decrypted message is: Hello
Comments
ChangeAll|z|l
zzHe → llHe (We replace all occurrences of 'z' with 'l')
Insert|2|o
llHe → lloHe (We add an 'o' before the character on index 2)
Move|3
lloHe → Hello (We take the first three characters and move them to the end of the string)
Finally, after receiving the "Decode" command, we print the resulting message.
Input		Output
[
  'owyouh',
  'Move|2',
  'Move|3',
  'Insert|3|are',
  'Insert|9|?'
  'Decode',
]	The decrypted message is: howareyou?
