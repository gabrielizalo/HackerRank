# Week of Code 37
## The Average Rating of Top Employees

Your submission will run against only preliminary test cases. Full test cases will run at the end of the day.
The general manager of Byteland Company has decided to rate all of the employees for their performance during this year. The rating will be a score in the range of 90 - 100 (inclusive) points. The manager wants to compute the average rating of all employees whose rating is greater or equal to 90 since he wants to give them a bonus for their good performance.

image

Complete the function averageOfTopEmployees which takes in an integer array  denoting the ratings of the employees and prints the average rating of employees who will get a bonus, with exactly  digits after the decimal point, rounded half up. (For example,  should be rounded to , while  should be rounded to .)

Input Format

The first line contains a single integer  denoting the number of employees in the Byteland Company. Then,  lines follow. The  of them contains a single integer  denoting the rating of the  employee.

Constraints

It's guaranteed that there is at least one employee with a rating 
Output Format

Print a single line containing a real number denoting the average rating of employees who will get a bonus. This number has to have exactly  digits after the decimal point, rounded half up. (For example,  should be rounded to , while  should be rounded to .)

Sample Input 0

5
84
92
61
50
95
Sample Output 0

93.50
Explanation 0

There are only two employees whose rating is equal or greater to . They are the only ones who are getting a bonus. Computing the average, we get:


image
