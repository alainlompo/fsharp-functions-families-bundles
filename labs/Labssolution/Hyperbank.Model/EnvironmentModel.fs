module EnvironmentModel

open System

type CardType = 
    | Debit = 0
    | Credit = 1

type AtmStatus = 
    | Aktiv = 0
    | Inaktiv = 1

type Address(street: String, number: int, postalCode: String, city: String, country: String) =
    member this.street = street
    member this.number = number
    member this.postalCode = postalCode
    member this.city = city
    member this.country = country

type Card(name : String, accountNumber: int, expiration: DateTime, cardType: CardType) = 
    member this.name = name
    member this.accountNumber = accountNumber
    member this.expiration = expiration
    member this.cardType = cardType

type Atm(id: int, location: Address, amount: Decimal, status: AtmStatus) = 
    member this.id = id
    member this.location = location
    member this.amount = amount
    member this.status = status

type BankAgency(name : String, location: Address) = 
    member this.name = name
    member this.location = location


// Lab 5
// Task 5.2
// TODO: create high orders functions for filtering lists of objects of the specified type according to the specified criterias
//       - Subtask 1: write each filter independently from the others
//       - Subtask 2: create an implementation where it is possible to call a combination of the filters in any order
//
//       Entity              List filterable by
//       -------             ------------------
//       Atm                 AtmStatus
//       Card                CardType
//       Address             City
//       Address             Street 
//       Address             Country

// Lab 6
// Task 6.2
// TODO: In this task you create usefull map functionalities that will reuse later in building higher level services
//       - Subtask 1: Create a high order function that retrieves all cards that will expire in one month and return them
//                    in a collection of tuples made of the account number and the card number (There should be no repetitions of tuples)  
//       - Subtask 2: Create a high order function that retrieves all Atms that have become inactive
//                    return them as a collection grouped by location.





