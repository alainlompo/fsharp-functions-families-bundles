module FinancialService

open System

// Task 3.2.1
// TODO: Rewrite the computeInterest function using a lambda expression
let computeInterest (interestRate: Decimal, amount: Decimal)  = amount * interestRate

// Task 3.2.2
// TODO: Rewrite the computeNewAmount function using a lambda expression
let computeNewAmount (interestRate: Decimal, amount: Decimal) = amount + computeInterest(interestRate, amount)


// Task 3.3
// TODO: refactor the computeNewAmount function as a composition of two other functions

// Task 4.1
// TODO: create a high order function called calculateNewBalance that takes a function: calculateInterestRate as argument.
//       The function is a parameterized version of the computeNewAmount function where the exacte behavior is determined only
//       At runtime.

(*
Lab 7: parameterizing behavioral patterns

Hyperbank has implemented an advanced approach to compute interest for its customers
The interest rate is a composed of two components: the core interest rate and the additionnal interest rate

interest rate = core interest rate + additional interest rate

the core interest rate depend on the customer's classification according to the following table

Classification     Core interest rate
BRONZE             3%
SILVER             4%
GOLD               6%
DIAMOND            9%

The additional interest rate depends on the volume of incoming money transfert on the customer's account:

Volume of transfert  additional interest rate
< 1000               0.1%
1000 - 5000          0.3%
5000 - 25000         0.5%
> 25000              0.8%


- Implement these new behaviors and parameterize the functional family using a strategy design pattern.
- Implement unit test covering each nominal case from the list above.
*)




