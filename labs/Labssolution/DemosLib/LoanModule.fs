module LoanModule

open System

type Customer = 
    { 
        Name: string; YearlySalary: Decimal; ProfessionalExperience: int; SociallyFit: bool; 
        CriminalRecord: bool; YearlyTrainings: int;
    };;

let loanCriteria = 
    [
        (fun customer -> customer.CriminalRecord = true);
        (fun customer -> customer.YearlySalary < 60000.0M);
        (fun customer -> customer.ProfessionalExperience < 3);
        (fun customer -> customer.SociallyFit = false);
        (fun customer -> customer.YearlyTrainings < 2);
    ]

let assessShouldOfferLoanTo (customer) = 
    let failedCriteria = loanCriteria |> List.filter (fun f -> f customer)
    let offered = failedCriteria.Length <= 1
    printfn "Customer: %s\n Offer a loan: %s (unsatisfied criteria = %d)" customer.Name
        (if (offered) then "Yes" else "No") failedCriteria.Length;;

(* 
-----------------------------------------------------------
Demo 1: behaviors as function in F#
-----------------------------------------------------------
Uncomment and execute in interactive mode (Alt + Enter) to see this demo
let Jonathan = 
    {
        Name = "Jonathan Donovan"; YearlySalary = 53500.5M; ProfessionalExperience = 5;
        SociallyFit = true; CriminalRecord = false; YearlyTrainings = 3;
    };;

assessShouldOfferLoanTo(Jonathan);;
*)

(*
-----------------------------------------------------------
Demo 2: Demonstrating point free programming approach
-----------------------------------------------------------
Uncomment the code snippet and run in interactive mode (Alt + Enter) to see the demo
[1..10] |> List.map ((*) 15);;
*)

