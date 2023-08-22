# Monitor Devices & Messages!

This is the Homework assessment received from the Engineering Manager of Enterprise Software ****Daniel Pozner****. 


# Problem Description

I have monitor devices which are sending me data and I need to **compute the number of messages** I got or read from the devices.

## Constraints

1. Each device has a unique name.
2. Each device produces measurement**s**

## Example

1. ***Example 1***
 * monitor1 -> (123, 1241, 15325, 235)
 * monitor2 -> (152, 325)
 * monitor3 -> (1, 2, 5)

**The output should be only 9**
 
 2. ***Example 2***
 * monitor1 -> (123 1241 15325 235)
 * monitor2 -> (152 a5)
 * monitor3 -> (1 2)
 
**Inform the user to give the correct measurements**

## Solution Description

The index is named *Program.cs*. I created a monitor class to concatenate the properties of each monitor (Name & Measurements), I expected that each measurement would be an integer hence I created measurements as a list of integers to have elasticity in size. I will prompt the user for the number of monitors and also the measurements of each monitor then I will count the number of each measurement and print it to the standard output.

## Conclusion

The time complexity of this solution is to the big O of N^2 since there's a nested loop for the measurements fulfillment. 

## PS

***This is a prototype of the solution*** 
Problem can be solved in different ways, one of them can be using a dictionary (Hash table). Since each monitor has a unique name then I can put it as a *key* and the *value* of that dictionary would be an array of integers then I would sum up all the values of all the keys and print it to the standard output.
