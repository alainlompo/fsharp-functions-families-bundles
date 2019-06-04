module SystemModel

open System

type AccountClass = 
    | Personal=0 
    | Professional=1 
    | Enterprise=2

type AccountType = 
    | Chequing = 0
    | Savings = 1

type AccountCategory = 
    |Bronze = 0
    | Silver = 1 
    | Gold = 2 
    | Diamond = 3

type TransactionType = 
    | Withdraw = 0
    | Deposit = 1
    | Check_Balance = 2
    | Transfer_Funds = 3

type Account(accountNumber:int, balance: Decimal, interestRate: Decimal) =

    let mutable accountClassIntern: AccountClass = AccountClass.Enterprise
    let mutable accountCategoryIntern: AccountCategory = AccountCategory.Silver
    let mutable accountTypeIntern: AccountType = AccountType.Savings

    member this.accountNumber = accountNumber
    member this.balance = balance
    member this.interestRate = interestRate
    member this.Type
        with get(): AccountType = accountTypeIntern
        and set(value) = accountTypeIntern <- value
    member this.Category
        with get(): AccountCategory = accountCategoryIntern
        and set(value) = accountCategoryIntern <- value
    member this.Classification
        with get(): AccountClass = accountClassIntern
        and set(value) = accountClassIntern <- value

type Customer(name, phone, email, subscriptionDate: DateTime) =
    member this.Name = name
    member this.Phone = phone
    member this.Email = email
    member this.subscriptionDate = subscriptionDate

type Transaction(transactionType: TransactionType, timeStamp: String, amount: Decimal, balance: Decimal, validTransaction: bool) = 
    member this.transactionType = transactionType
    member this.timeStamp = timeStamp 
    member this.amount = amount
    member this.balance = balance
    member this.validTransaction = validTransaction

type CustomerSession(sessionTimeout: String, isAuthorized: bool, canModify: bool, limit: Decimal) = 
    member this.sessionTimeout = sessionTimeout
    member this.isAuthorized = isAuthorized
    member this.canModify = canModify
    member this.limit = limit

type CustomerFile =
    | CustomerInfos of Customer
    | Accounts of List<Account>
    | Transactions of List<Transaction>
    | AktiveSession of CustomerSession

// Lab 5
// Task 5.1
// TODO: create high orders functions for filtering lists of objects of the specified type according to the specified criterias
//       - Subtask 1: write each filter independently from the others
//       - Subtask 2: create an implementation where it is possible to call a combination of the filters in any order
//
//       Entity              List filterable by
//       -------             ------------------
//       Account             AccountType
//       Account             AccountCategory
//       Account             AccountClass
//       Customer            Subscription date
//       Transaction         transaction's validity
//       Transaction         amount greater than a given value
//       Transaction         amount smaller than a specified value
//       Transaction         amount smaller than a specified value


// Lab 6
// Task 6.1
// TODO: In this task you create usefull map functionalities that will reuse later in building higher level services
//       - Subtask 1: Extend the Customer model with a unique identifier
//       - Subtask 2: Create a high order function that retrieves all transactoions with a negative amount and collects them into a tuple
//                    made of the customer's id and the list of matching transactions
//       - Subtask 3: Create a high order function that retrieves all transactoions with a positive amount and collects them into a tuple
//                    made of the customer's id and the list of matching transactions






