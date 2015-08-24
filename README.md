# BusinessCase3
Simple/Naive Encryption Function

Monday 24 Aug 2015 5:45pm GMT+8

Business Case 3: Implementing a simple/naive encryption function

* The IT manager of Dafesty wants to create a simple encryption function for use in various situations inside the application.
* Write a static method: Encrypt(string s) that would return the encrypted value.  The purpose of this method is to encrypt the string s.  You may follow a simple, naive algorithm for encryption as described below.  String s can be only alpha numeric (no special characters permitted)

NOTE: Steps for Encryption below:

Step 1:
Change each character in the string by replacing it with the next character in the alphabet series.  For instance, letter a would be replaced by letter b, letter p would be replaced by letter q etc. and letter z would be replaced by a.  Similarly letter A would be replaced by letter B, letter P by letter Q and letter Z by A.  Likewise, character 1 would be replaced by character 2, character 5 by character 6 and character 9 by character 0.

Step 2:
Invert the word by making a mirror image of it.

Example:
Consider the word:            SeazAme94
FirstTransformation:        TfbaBnf05
Second Transformation: 50fnBabfT

Finished at: Monday 24 Aug 2015 7:46pm GMT+8
